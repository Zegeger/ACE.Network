////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;
using System.IO;
using System.Collections.Generic;
using ACE.Network.Enums;
using ACE.Network.Extensions;

namespace ACE.Network.Types
{
    /// <summary>
    /// Data related to an item, namely the amount and description
    /// </summary>
    public class ItemProfile : IPackable
    {
        /// <summary>
        /// the number of items for sale (-1 for an unlimited supply)
        /// </summary>
        [MessageProperty]
        public int Amount { get; set; }        
        
        
        /// <summary>
        /// flag indicating whether the new or old PublicWeenieDesc is used
        /// </summary>
        [MessageProperty]
        public sbyte PwdType { get; set; }        
        
        
        /// <summary>
        /// the object ID of the item
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        
        /// <summary>
        /// details about the item
        /// </summary>
        [MessageProperty]
        public PublicWeenieDesc Pwd { get; } = new PublicWeenieDesc();
        
        /// <summary>
        /// details about the item
        /// </summary>
        [MessageProperty]
        public OldPublicWeenieDesc Opwd { get; } = new OldPublicWeenieDesc();
        


        public void Unpack(BinaryReader reader)
        {
            uint PackedAmount = reader.ReadUInt32();
            if((PackedAmount & 0x800000) != 0) // Is the subvalue negative?
                Amount = (int)(PackedAmount & 0xFFFFFF | 0xFF000000);
            else
                Amount = (int)(PackedAmount & 0xFFFFFF);
            PwdType = (sbyte)(PackedAmount >> 24);
            ObjectID = reader.ReadUInt32();
            switch(PwdType)
            {
                case -1:
                    Pwd.Unpack(reader);
                break;
                case 1:
                    Opwd.Unpack(reader);
                break;
            }

        }

        public void Pack(BinaryWriter writer)
        {
            uint PackedAmount = 0;
            PackedAmount |= (uint)(PwdType << 24);
            writer.Write(PackedAmount);
            writer.Write(ObjectID);
            switch(PwdType)
            {
                case -1:
                    Pwd.Pack(writer);
                break;
                case 1:
                    Opwd.Pack(writer);
                break;
            }

        }


    }
}
