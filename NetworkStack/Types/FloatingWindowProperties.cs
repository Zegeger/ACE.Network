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
    public class FloatingWindowProperties
    {
        int? ChatWindowXPosition { get; set; }
        int? ChatWindowYPosition { get; set; }
        int? ChatWindowXSize { get; set; }
        int? ChatWindowYSize { get; set; }
        bool? Enabled { get; set; }
        string Title { get; set; }
        ChatDisplayMask? DisplayMask { get; set; }

        public void Unpack(StructPropertyValue spv)
        {
            ChatWindowXPosition = spv.GetProperty<IntegerPropertyValue>(PropertyType.ChatWindowXPosition)?.Value;
            ChatWindowYPosition = spv.GetProperty<IntegerPropertyValue>(PropertyType.ChatWindowYPosition)?.Value;
            ChatWindowXSize = spv.GetProperty<IntegerPropertyValue>(PropertyType.ChatWindowXSize)?.Value;
            ChatWindowYSize = spv.GetProperty<IntegerPropertyValue>(PropertyType.ChatWindowYSize)?.Value;
            Enabled = spv.GetProperty<BooleanPropertyValue>(PropertyType.ChatWindowEnabled)?.Value;
            Title = spv.GetProperty<StringInfoPropertyValue>(PropertyType.ChatWindowTitle)?.Value;
            DisplayMask = (ChatDisplayMask?)spv.GetProperty<Bitfield64PropertyValue>(PropertyType.ChatWindowDisplayMask)?.Value;
        }

        public StructPropertyValue Pack()
        {
            StructPropertyValue spv = new StructPropertyValue();
            if (Title != null)
                spv.AddProperty<StringInfoPropertyValue>(PropertyType.ChatWindowTitle).Value = Title;
            if (ChatWindowXPosition.HasValue)
                spv.AddProperty<IntegerPropertyValue>(PropertyType.ChatWindowXPosition).Value = ChatWindowXPosition.Value;
            if (ChatWindowYPosition.HasValue)
                spv.AddProperty<IntegerPropertyValue>(PropertyType.ChatWindowYPosition).Value = ChatWindowYPosition.Value;
            if (ChatWindowXSize.HasValue)
                spv.AddProperty<IntegerPropertyValue>(PropertyType.ChatWindowXSize).Value = ChatWindowXSize.Value;
            if (ChatWindowYSize.HasValue)
                spv.AddProperty<IntegerPropertyValue>(PropertyType.ChatWindowYSize).Value = ChatWindowYSize.Value;
            if (DisplayMask.HasValue)
                spv.AddProperty<Bitfield64PropertyValue>(PropertyType.ChatWindowDisplayMask).Value = (ulong)DisplayMask.Value;
            if (Enabled.HasValue)
                spv.AddProperty<BooleanPropertyValue>(PropertyType.ChatWindowEnabled).Value = Enabled.Value;
            return spv;
        }
    }
}
