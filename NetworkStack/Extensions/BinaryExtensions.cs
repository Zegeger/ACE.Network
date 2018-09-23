using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.IO;

namespace ACE.Network.Extensions
{
    public static class BinaryExtensions
    {
        /// <summary>
        /// Checks the bytes remaining in a BinaryReader
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static long BytesRemaining(this BinaryReader reader)
        {
            return reader.BaseStream.Length - reader.BaseStream.Position;
        }

        /// <summary>
        /// Reads an ASCII string where the number of characters is the first two bytes.  Buffer is aligned to 4 byte boundary.
        /// </summary>
        /// <param name="reader">BinaryReader to read string from at the current position</param>
        /// <returns>String value read</returns>
        public static string ReadString16L(this BinaryReader reader)
        {
            ushort length = reader.ReadUInt16();
            string rdrStr = (length != 0 ? Encoding.ASCII.GetString(reader.ReadBytes(length)) : string.Empty);
            // client pads string length to be a multiple of 4 including the 2 bytes for length
            reader.Skip(CalculatePadMultiple(sizeof(ushort) + (uint)length, 4u));
            return rdrStr;
        }

        /// <summary>
        /// Writes an ASCII string starting with the number of characters as the first two bytes.  Buffer is aligned to 4 byte boundary.
        /// </summary>
        /// <param name="writer">BinaryWriter to write the string too</param>
        /// <param name="value">String value to write</param>
        public static void WriteString16L(this BinaryWriter writer, string value)
        {
            writer.Write((ushort)value.Length);
            writer.Write(Encoding.ASCII.GetBytes(value));
            writer.Pad(CalculatePadMultiple(sizeof(ushort) + (uint)value.Length, 4u));
        }

        /// <summary>
        /// Reads Unicode string with the number of characters as the first byte. Bytes read are length * 2. 
        /// </summary>
        /// <param name="reader">BinaryReader to read string from at the current position</param>
        /// <returns>String value read</returns>
        public static string ReadWString(this BinaryReader reader)
        {
            byte length = reader.ReadByte();
            if (length == 0)
                return string.Empty;
            byte[] content = reader.ReadBytes(length * 2);
            return Encoding.Unicode.GetString(content);
        }

        /// <summary>
        /// Writes a Unicode string starting with the number of characters as the first byte.
        /// </summary>
        /// <param name="writer">BinaryWriter to write the string too</param>
        /// <param name="value">String value to write</param>
        public static void WriteWString(this BinaryWriter writer, string value)
        {
            writer.Write((byte)value.Length);
            writer.Write(Encoding.Unicode.GetBytes(value));
        }

        /// <summary>
        /// Reads an ASCII string with the number of characters first.  Number of characters is read as a compressed uint.
        /// </summary>
        /// <param name="reader">BinaryReader to read string from at the current position</param>
        /// <returns>String value read</returns>
        public static string ReadPString(this BinaryReader reader)
        {
            int length = (int)reader.ReadUIntCompressed8();
            if (length == 0)
                return string.Empty;
            return Encoding.ASCII.GetString(reader.ReadBytes(length));
        }

        /// <summary>
        /// Writes an ASCII string with the number of characters first.  Number of characters is written as a compressed uint.
        /// </summary>
        /// <param name="writer">BinaryWriter to write the string too</param>
        /// <param name="value">String value to write</param>
        public static void WritePString(this BinaryWriter writer, string value)
        {
            writer.WriteUIntCompressed8((uint)value.Length);
            writer.Write(Encoding.ASCII.GetBytes(value));
        }

        /// <summary>
        /// Reads uint as a boolean value.  Any value other then 0 indicates true.
        /// </summary>
        /// <param name="reader">BinaryReader to read boolean from at the current position</param>
        /// <returns>Boolean value read</returns>
        public static bool ReadBool32(this BinaryReader reader)
        {
            return reader.ReadUInt32() != 0;
        }

        /// <summary>
        /// Writes a boolean as a uint. True is written as 1, False is written as 0.
        /// </summary>
        /// <param name="writer">BinaryWriter to write the boolean too</param>
        /// <param name="value">Boolean value to write</param>
        public static void WriteBool32(this BinaryWriter writer, bool value)
        {
            if (value)
                writer.Write(1u);
            else
                writer.Write(0u);
        }

        /// <summary>
        /// Reads a compressed UInt, which is either one, two, or four bytes based on the size of the value.
        /// A value which is 127 or less will be read as one byte.
        /// A value which is ‭16383‬ or less will be read as two bytes.
        /// Greater values will be read as four bytes.
        /// </summary>
        /// <param name="reader">BinaryReader to read compressed uint from at the current position</param>
        /// <returns>uint value read</returns>
        public static uint ReadUIntCompressed8(this BinaryReader reader)
        {
            uint value = 0;
            byte b1 = reader.ReadByte();
            if ((b1 & 0x80) == 0)
            {
                value = b1;
            }
            else
            {
                byte b2 = reader.ReadByte();
                if ((b1 & 0x40) != 0)
                {
                    ushort s1 = reader.ReadUInt16();
                    value = (uint)(b1 & 0x3F) << 24;
                    value |= (uint)b2 << 16;
                    value |= s1;
                }
                else
                {
                    value = (uint)(b1 & 0x7F) << 8;
                    value |= b2;
                }
            }
            return value;
        }

        /// <summary>
        /// Writes a compressed UInt, which is either one, two, or four bytes based on the size of the value.
        /// A value which is 127 or less will be written as one byte.
        /// A value which is ‭16383‬ or less will be written as two bytes.
        /// Greater values will be written as four bytes.
        /// </summary>
        /// <param name="writer">BinaryWriter to write the compressed uint too</param>
        /// <param name="value">uint to write</param>
        public static void WriteUIntCompressed8(this BinaryWriter writer, uint value)
        {
            if (value > 0x7F)
            {
                if (value > 0x3FFF)
                {
                    writer.Write((byte)((value >> 24) | 0xC0));
                    writer.Write((byte)(value >> 16));
                    writer.Write((ushort)value);
                }
                else
                {
                    writer.Write((byte)((value >> 24) | 0x80));
                    writer.Write((byte)(value >> 16));
                }
            }
            else
            {
                writer.Write((byte)value);
            }
        }

        /// <summary>
        /// Reads a compressed UInt, which is either two or four bytes based on the size of the value.
        /// A value which is ‭32767‬ or less will be read as two bytes.
        /// Greater values will be read as four bytes.
        /// </summary>
        /// <param name="reader">BinaryReader to read compressed uint from at the current position</param>
        /// <returns>uint value read</returns>
        public static uint ReadUIntCompressed16(this BinaryReader reader)
        {
            uint value = 0;
            ushort s1 = reader.ReadUInt16();
            if ((s1 & 0x8000) == 0)
            {
                value = s1;
            }
            else
            {
                ushort s2 = reader.ReadUInt16();
                value = (uint)(s1 & 0x7FFF) << 16;
                value |= s2;
            }
            return value;
        }

        /// <summary>
        /// Writes a compressed UInt, which is either two or four bytes based on the size of the value.
        /// A value which is ‭32767‬ or less will be written as two bytes.
        /// Greater values will be written as four bytes.
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        public static void WriteUIntCompressed16(this BinaryWriter writer, uint value)
        {
            if (value > 0x7FFF)
            {
                writer.Write((ushort)((value >> 16) | 0x80));
                writer.Write((ushort)value);
            }
            else
            {
                writer.Write((ushort)value);
            }
        }

        /// <summary>
        /// Writes a set of bytes as a string block for diagnostic purposes.
        /// </summary>
        /// <param name="bytes">Byte array to be written out</param>
        /// <param name="startPosition">Start position in the array</param>
        /// <param name="bytesToOutput">Number of bytes to output</param>
        /// <returns></returns>
        public static string BuildPacketString(this byte[] bytes, int startPosition = 0, int bytesToOutput = 9999)
        {
            TextWriter tw = new StringWriter();
            byte[] buffer = bytes;

            int column = 0;
            int row = 0;
            int columns = 16;
            tw.Write("   x  ");
            for (int i = 0; i < columns; i++)
            {
                tw.Write(i.ToString().PadLeft(3));
            }
            tw.WriteLine("  |Text");
            tw.Write("   0  ");

            string asciiLine = "";
            for (int i = 0; i < buffer.Length; i++)
            {
                if (column >= columns)
                {
                    row++;
                    column = 0;
                    tw.WriteLine("  |" + asciiLine);
                    asciiLine = "";
                    tw.Write((row * columns).ToString().PadLeft(4));
                    tw.Write("  ");
                }

                tw.Write(buffer[i].ToString("X2").PadLeft(3));

                if (Char.IsControl((char)buffer[i]))
                    asciiLine += " ";
                else
                    asciiLine += (char)buffer[i];
                column++;
            }

            tw.Write("".PadLeft((columns - column) * 3));
            tw.WriteLine("  |" + asciiLine);
            return tw.ToString();
        }

        /// <summary>
        /// Aligns a writer to a specific byte length boundary.
        /// </summary>
        /// <param name="writer">BinaryWriter to align</param>
        /// <param name="boundary">Boundary multiple to align the stream to</param>
        public static void Align(this BinaryWriter writer, uint boundary = 4)
        {
            writer.Pad(CalculatePadMultiple((uint)writer.BaseStream.Position, boundary));
        }

        /// <summary>
        /// Aligns a reader to a specific byte length boundary
        /// </summary>
        /// <param name="reader">BinaryReader to align</param>
        /// <param name="boundary">Boundary multiple to align the stream to</param>
        public static void Align(this BinaryReader reader, uint boundary = 4)
        {
            reader.ReadBytes((int)CalculatePadMultiple((uint)reader.BaseStream.Position, boundary));
        }

        /// <summary>
        /// Calculate a pad length to align a the given length to the given multiple
        /// </summary>
        /// <param name="length">Current length value</param>
        /// <param name="multiple">Desired multiple alignment</param>
        /// <returns>Required padding to take the length to the next multiple boundary</returns>
        public static uint CalculatePadMultiple(uint length, uint multiple)
        {
            return multiple * ((length + multiple - 1u) / multiple) - length;
        }

        /// <summary>
        /// Pads a writer with the specified number of bytes
        /// </summary>
        /// <param name="writer">BinaryWriter to pad</param>
        /// <param name="pad">Number of bytes to pad</param>
        public static void Pad(this BinaryWriter writer, uint pad) { writer.Write(new byte[pad]); }

        /// <summary>
        /// Skips the specified number of bytes in the reader
        /// </summary>
        /// <param name="reader">BinaryReader to skip bytes in</param>
        /// <param name="length">Number of bytes to skip</param>
        public static void Skip(this BinaryReader reader, uint length) { reader.BaseStream.Position += length; }
    }
}
