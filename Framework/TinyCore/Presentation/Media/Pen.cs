////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Microsoft Corporation.  All rights reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;

namespace Microsoft.SPOT.Presentation.Media
{
    public class Pen
    {
        public Color Color;
        public ushort Thickness;

        public Pen(Color color)
            : this(color, 1)
        {
        }

        public Pen(Color color, ushort thickness)
        {
            Color = color;
            Thickness = thickness;
        }
    }
}


