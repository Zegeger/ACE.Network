////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;

namespace ACE.Network.Enums
{
    /// <summary>
    /// The PositionFlags value defines the fields present in the Position structure.
    /// </summary>
    public enum PositionFlags : uint
    {
        
        /// <summary>
        /// velocity vector is present
        /// </summary>
        HasVelocity = 0x00000001,
        
        /// <summary>
        /// placement id is present
        /// </summary>
        HasPlacementID = 0x00000002,
        
        /// <summary>
        /// object is grounded
        /// </summary>
        IsGrounded = 0x00000004,
        
        /// <summary>
        /// orientation quaternion has no w component
        /// </summary>
        OrientationHasNoW = 0x00000008,
        
        /// <summary>
        /// orientation quaternion has no x component
        /// </summary>
        OrientationHasNoX = 0x00000010,
        
        /// <summary>
        /// orientation quaternion has no y component
        /// </summary>
        OrientationHasNoY = 0x00000020,
        
        /// <summary>
        /// orientation quaternion has no z component
        /// </summary>
        OrientationHasNoZ = 0x00000040
    }
}
