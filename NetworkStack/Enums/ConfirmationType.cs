////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;

namespace ACE.Network.Enums
{
    /// <summary>
    /// The ConfirmationType identifies the specific confirmation panel to be displayed.
    /// </summary>
    public enum ConfirmationType : uint
    {
        
        /// <summary>
        /// Swear Allegiance Request
        /// </summary>
        SwearAllegiance = 0x00000001,
        
        /// <summary>
        /// Alter Skill Confirmation Request
        /// </summary>
        AlterSkill = 0x00000002,
        
        /// <summary>
        /// Alter Attribute Confirmation Request
        /// </summary>
        AlterAttribute = 0x00000003,
        
        /// <summary>
        /// Fellowship Request
        /// </summary>
        Fellowship = 0x00000004,
        
        /// <summary>
        /// Craft Interaction Confirmation Request
        /// </summary>
        Craft = 0x00000005,
        
        /// <summary>
        /// Augmentation Confirmation Request
        /// </summary>
        Augmentation = 0x00000006,
        
        /// <summary>
        /// Yes/No Confirmation Request
        /// </summary>
        YesNo = 0x00000007
    }
}
