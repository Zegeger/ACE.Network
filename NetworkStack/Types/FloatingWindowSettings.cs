using System;
using System.IO;
using System.Collections.Generic;
using ACE.Network.Enums;
using ACE.Network.Extensions;
using ACE.Network.PropertyTypes;

namespace ACE.Network.Types
{
    /// <summary>
    /// Contains information related to the floating chat windows
    /// </summary>
    public class FloatingWindowSettings : IPackable
    {
        float? ActiveWindowOpacity { get; set; }
        float? InactiveWindowOpacity { get; set; }
        List<FloatingWindowProperties> Windows { get; } = new List<FloatingWindowProperties>();


        public void Unpack(BinaryReader reader)
        {
            Windows.Clear();
            PropertyCollection pc = new PropertyCollection();
            pc.Unpack(reader);
            InactiveWindowOpacity = pc.GetProperty<FloatPropertyValue>(PropertyType.InactiveWindowOpacity)?.Value;
            ActiveWindowOpacity = pc.GetProperty<FloatPropertyValue>(PropertyType.ActiveWindowOpacity)?.Value;
            var windows = pc.GetProperty<ArrayPropertyValue>(PropertyType.ChatWindowArray)?.Value;
            foreach(var window in windows)
            {
                FloatingWindowProperties fwp = new FloatingWindowProperties();
                fwp.Unpack((StructPropertyValue)window.Value);
            }
        }

        public void Pack(BinaryWriter writer)
        {
            PropertyCollection pc = new PropertyCollection();
            if (InactiveWindowOpacity.HasValue)
                pc.AddProperty<FloatPropertyValue>(PropertyType.InactiveWindowOpacity).Value = InactiveWindowOpacity.Value;
            var list = pc.AddProperty<ArrayPropertyValue>(PropertyType.ChatWindowArray).Value;
            foreach(var window in Windows)
            {
                BaseProperty bp = new BaseProperty();
                bp.Type = PropertyType.ChatWindowPropertyTable;
                bp.Value = window.Pack();
                list.Add(bp);
            }
            if (ActiveWindowOpacity.HasValue)
                pc.AddProperty<FloatPropertyValue>(PropertyType.ActiveWindowOpacity).Value = ActiveWindowOpacity.Value;
        }
    }
}
