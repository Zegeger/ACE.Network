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
    /// Instructs the client to play a script. (Not seen so far, maybe prefered PlayScriptType)
    /// </summary>
    public class PlayScriptIDS2C : Message
    {
        /// <summary>
        /// ID of the object to play the script
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        
        /// <summary>
        /// ID of script to be played
        /// </summary>
        [MessageProperty]
        public uint ScriptID { get; set; }        
        


        public PlayScriptIDS2C() : base((MessageType)0xF754, MessageDirection.ServerToClient, (Queues)0x0000000A)
        { }

        public PlayScriptIDS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ObjectID = reader.ReadUInt32();
            ScriptID = reader.ReadUIntCompressed16();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ObjectID);
            writer.WriteUIntCompressed16(ScriptID);

        }


    }
}
