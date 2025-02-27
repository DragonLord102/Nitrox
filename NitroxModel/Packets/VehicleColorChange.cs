﻿using System;
using NitroxModel.DataStructures;
using NitroxModel.DataStructures.Unity;

namespace NitroxModel.Packets
{
    [Serializable]
    public class VehicleColorChange : Packet
    {
        public NitroxId Id { get; }
        public int Index { get; }
        public NitroxVector3 HSB { get; }
        public NitroxColor Color { get; }

        public VehicleColorChange(int index, NitroxId id, NitroxVector3 hsb, NitroxColor color)
        {
            Id = id;
            Index = index;
            HSB = hsb;
            Color = color;
        }
    }
}
