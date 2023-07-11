﻿using System.Drawing;

namespace automotive.Models.Objects
{
    public class Body
    {
        public int          Height { get; set; }
        public int          Width { get; set; }
        public Color        Color { get; set; }
        public MaterialType Material { get; set; }
    }
}