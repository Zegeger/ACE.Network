////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;

namespace ACE.Network.Enums
{
    /// <summary>
    /// The ChatDisplayMask identifies that types of chat that are displayed in each chat window. This is based on ChatMessageType. 1 << ChatMessageType
    /// </summary>
    public enum ChatDisplayMask : ulong
    {
        
        /// <summary>
        /// Gameplay (main chat window only). Default, System, Advancement, Help, Appraisal, WorldBroadcast, Recall, Craft, Salvaging
        /// </summary>
        Gameplay = 0x0000000003912021,
        
        /// <summary>
        /// Mandatory (main chat window only, cannot be disabled) Channels, OutgoingSocial, Abuse, Help
        /// </summary>
        Mandatory = 0x000000000000c302,
        
        /// <summary>
        /// Area Chat. Speech, Emote
        /// </summary>
        AreaSpeech = 0x0000000000001004,
        
        /// <summary>
        /// Tells. Tell, OutgoingTell
        /// </summary>
        Tells = 0x0000000000000018,
        
        /// <summary>
        /// Combat. Combat, CombatEnemy, CombatSelf
        /// </summary>
        Combat = 0x0000000000600040,
        
        /// <summary>
        /// Magic. Magic, Spellcasting
        /// </summary>
        Magic = 0x0000000000020080,
        
        /// <summary>
        /// Allegiance. Social, OutgoingSocial, Allegiance
        /// </summary>
        Allegience = 0x0000000000040c00,
        
        /// <summary>
        /// Fellowship
        /// </summary>
        Fellowship = 0x0000000000080000,
        
        /// <summary>
        /// Errors
        /// </summary>
        Errors = 0x0000000004000000,
        
        /// <summary>
        /// General Channel
        /// </summary>
        GeneralChannel = 0x0000000008000000,
        
        /// <summary>
        /// Trade Channel
        /// </summary>
        TradeChannel = 0x0000000010000000,
        
        /// <summary>
        /// LFG Channel
        /// </summary>
        LFGChannel = 0x0000000020000000,
        
        /// <summary>
        /// Roleplay Channel
        /// </summary>
        RoleplayChannel = 0x0000000040000000,
        
        /// <summary>
        /// Society Channel
        /// </summary>
        SocietyChannel = 0x0000000100000000
    }
}
