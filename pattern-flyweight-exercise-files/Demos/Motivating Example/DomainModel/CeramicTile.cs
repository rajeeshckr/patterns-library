﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DomainModel
{
    public class CeramicTile : ITile
    {
        public static int ObjectCounter = 0;

        Brush paintBrush;        

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public CeramicTile(int x, int y, int width, int height)
        {
            paintBrush = Brushes.Red;
            X = x;
            Y = y;
            Width = width;
            Height = height;

            ++ObjectCounter;
        }

        public void Draw(Graphics g)
        {
            g.FillRectangle(paintBrush, X, Y, Width, Height);
        }
    }
}