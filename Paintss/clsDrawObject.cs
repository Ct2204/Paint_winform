﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace Paintss
{
    public abstract class clsDrawObject : Form1
    {
        public Point p1 { get; set; }
        public Point p2 { get; set; }

        public Pen myPen { get; set; }
        public Brush myBrush { get; set; }
        public abstract void Draw(Graphics myGp);
        
    };
}
