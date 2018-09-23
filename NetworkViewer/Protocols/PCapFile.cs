using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACE.Network.Tools.NetworkViewer.Protocols
{
    public class PCapFile
    {
        public uint MagicNumber { get; }
        public ushort VersionMajor { get; private set; }
        public ushort VersionMinor { get; private set; }
        public uint ThisZone { get; private set; }
        public uint SigFigs { get; private set; }
        public uint SnapLen { get; private set; }
        public uint Network { get; private set; }

        public event EventHandler<PacketReadEventArgs> PacketRead;

        public List<PCapRecord> Records { get; } = new List<PCapRecord>();

        private bool raiseEvents = false;
           
        public PCapFile(uint magicNumber)
        {
            MagicNumber = magicNumber;
            raiseEvents = true;
        }

        public PCapFile(uint magicNumber, BinaryReader binaryReader)
        {
            raiseEvents = false;
            Parse(binaryReader);
        }

        public void Parse(BinaryReader binaryReader)
        {
            try
            {
                VersionMajor = binaryReader.ReadUInt16();
                VersionMinor = binaryReader.ReadUInt16();
                ThisZone = binaryReader.ReadUInt32();
                SigFigs = binaryReader.ReadUInt32();
                SnapLen = binaryReader.ReadUInt32();
                Network = binaryReader.ReadUInt32();

                ulong packetNumber = 1;

                while (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
                {
                    var record = new PCapRecord(binaryReader, packetNumber++);
                    if (!raiseEvents)
                        Records.Add(record);
                    else
                        PacketRead?.Invoke(this, new PacketReadEventArgs(record));
                }
            }
            catch (EndOfStreamException)
            {
            }
        }
    }
}
