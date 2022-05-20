using System;
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
   
    public class clsLine : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {
            
            myGp.DrawLine(myPen, this.p1, this.p2);
        }
    }
    public class clsEllipse : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {
            
            myGp.DrawEllipse(myPen, this.p1.X, this.p1.Y, this.p2.X - this.p1.X, this.p2.Y - this.p1.Y);
        }
    }
    public class clsRectangle : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {
            myGp.DrawRectangle(myPen, this.p1.X, this.p1.Y, this.p2.X - this.p1.X, this.p2.Y - this.p1.Y);
        }
    }
    public class clsCircle : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {
            myGp.DrawEllipse(myPen, this.p1.X, this.p1.Y, this.p2.X - this.p1.X, this.p2.X - this.p1.X);
        }
    }


    /*public class clsPolygon : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {

            PointF[] curvePoints =
                     {
                this.p1.X, this.p1.Y
             };
            myGp.DrawPolygon(myPen, curvePoints);
        }
    }*/

    public class clsFillEllipse : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {
           
            myGp.FillEllipse(myBrush, this.p1.X, this.p1.Y, this.p2.X - this.p1.X, this.p2.Y - this.p1.Y);
        }
    }

    public class clsFillRect : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {
            myGp.FillRectangle(myBrush, this.p1.X, this.p1.Y, this.p2.X - this.p1.X, this.p2.Y - this.p1.Y);
        }
    }

    public class clsFillCircle : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {
            
            myGp.FillEllipse(myBrush, this.p1.X, this.p1.Y, this.p2.X - this.p1.X, this.p2.X - this.p1.X);
        }
    }

    public class clsSelect : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {
            myPen.DashStyle= DashStyle.Dot;
            myPen.Color = Color.Black;
            myGp.DrawRectangle(myPen, this.p1.X, this.p1.Y, this.p2.X - this.p1.X, this.p2.X - this.p1.X);
        }
    }

}
