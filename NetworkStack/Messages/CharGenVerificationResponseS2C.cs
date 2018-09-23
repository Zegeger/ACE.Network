////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;
using System.IO;
using System.Collections.Generic;
using ACE.Network.Enums;
using ACE.Network.Types;
using ACE.Network.Extensions;

namespace ACE.Network.Messages
{
    /// <summary>
    /// Character creation screen initilised.
    /// </summary>
    public class CharGenVerificationResponseS2C : Message
    {
        /// <summary>
        /// Type of response
        /// </summary>
        [MessageProperty]
        public CharGenResponseType ResponseType { get; set; }        
        
        /// <summary>
        /// The character ID for this entry.
        /// </summary>
        [MessageProperty]
        public uint Gid { get; set; }        
        
        /// <summary>
        /// The name of this character.
        /// </summary>
        [MessageProperty]
        public string Name { get; set; }        
        
        /// <summary>
        /// When 0, this character is not being deleted (not shown crossed out). Otherwise, it's a countdown timer in the number of seconds until the character is submitted for deletion.
        /// </summary>
        [MessageProperty]
        public uint SecondsGreyedOut { get; set; }        
        


        public CharGenVerificationResponseS2C() : base((MessageType)0xF643, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public CharGenVerificationResponseS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ResponseType = (CharGenResponseType)reader.ReadUInt32();
            switch(ResponseType)
            {
                case CharGenResponseType.OK:
                    Gid = reader.ReadUInt32();
                    Name = reader.ReadString16L();
                    SecondsGreyedOut = reader.ReadUInt32();
                    reader.Align();
                break;
            }

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write((uint)ResponseType);
            switch(ResponseType)
            {
                case CharGenResponseType.OK:
                    writer.Write(Gid);
                    writer.WriteString16L(Name);
                    writer.Write(SecondsGreyedOut);
                    writer.Align();
                break;
            }

        }


    }
}
