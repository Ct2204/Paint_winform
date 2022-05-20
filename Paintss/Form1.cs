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
    public partial class Form1 : Form
    {
        Graphics gp;
        Color myColor;
        Pen myPen;
        Brush myBrush;
        float width;
        Point p1;
        Point p2;

        Point pMain;


        bool bLine = false;
        bool bEcllipse = false;
        bool bRect = false;
        bool bFillEllipse = false;
        bool bFillRect = false;
        bool bCurve = false;
        bool bCircle = false;
        bool bFillCircle = false;
        bool bPoly = false;
        bool bFillPoly = false;
        bool bSelect = false;
        bool checkSelect = false;
        int i = 0;

        // List of ojbects
        

        List<clsDrawObject> lstObject = new List<clsDrawObject>();
        clsDrawObject myObj;
        
        bool isPress = false;


        // Constructor
        public Form1()
        {
            InitializeComponent();
            gp = this.pnMain.CreateGraphics();
            myColor = Color.Red;
            width = 4.0F;
            myPen = new Pen(myColor,width);
            myBrush = new SolidBrush(myColor);
            
        }


       // Tương tác vs button
        private void btnLine_Click(object sender, EventArgs e)
        {
            this.bLine = true;
        }

        private void btnEcllipse_Click(object sender, EventArgs e)
        {
            this.bEcllipse = true;
        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            this.bRect = true;
        }

       
        

        private void btnFillEllipse_Click(object sender, EventArgs e)
        {
            this.bFillEllipse = true;
        }

        private void btnFillRect_Click(object sender, EventArgs e)
        {
            this.bFillRect = true;

        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            this.bCircle = true;
        }

        private void btnFillCircle_Click(object sender, EventArgs e)
        {
            this.bFillCircle = true;
        }

        private void btnPoly_Click(object sender, EventArgs e)
        {
            this.bPoly = true;
        }

        private void btnFillPoly_Click(object sender, EventArgs e)
        {
            this.bFillPoly = true;
        }

        private void btnCurve_Click(object sender, EventArgs e)
        {
            this.bCurve = true;
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < lstObject.Count; i++)
            {
                this.lstObject[i].Draw(this.gp);
            }
        }

        // kéo thả chuột
        private void pnMain_MouseDown(object sender, MouseEventArgs e)
        {
            this.isPress = true;
            if (this.bLine == true)
            {
                myObj = new clsLine();
                myObj.myPen = new Pen(myColor,width);
                myObj.myPen.DashStyle = myPen.DashStyle;
                myObj.p1 = e.Location;
                myObj.p2 = e.Location;
                this.lstObject.Add(myObj);
                
            }
            if (this.bEcllipse == true)
            {
              
                myObj = new clsEllipse();
                myObj.myPen =new Pen(myColor,width);
                myObj.myPen.DashStyle = myPen.DashStyle;
                myObj.p1 = e.Location;
                this.lstObject.Add(myObj);
            }
            if (this.bRect == true)
            {
             
                myObj = new clsRectangle();
                myObj.myPen = new Pen(myColor,width);
                myObj.myPen.DashStyle = myPen.DashStyle;
                myObj.p1 = e.Location;
                this.lstObject.Add(myObj);
            }
            if (this.bCircle == true)
            {
               
                myObj = new clsCircle();
                myObj.myPen = new Pen(myColor,width);
                myObj.myPen.DashStyle = myPen.DashStyle;
                myObj.p1 = e.Location;
                this.lstObject.Add(myObj);
            }
            if (this.bFillEllipse == true)
            {
         
                myObj = new clsFillEllipse();
                myObj.myBrush = new SolidBrush(myColor);
                myObj.p1 = e.Location;
                this.lstObject.Add(myObj);
            }
            if (this.bFillRect == true)
            {
            
                myObj = new clsFillRect();
                myObj.myBrush = new SolidBrush(myColor);
                myObj.p1 = e.Location;
                this.lstObject.Add(myObj);
            }
            if (this.bFillCircle == true)
            {
             
                myObj = new clsFillCircle();
                myObj.myBrush = new SolidBrush(myColor);
                myObj.p1 = e.Location;
                this.lstObject.Add(myObj);
                
               
            }
            if (this.bSelect == true)
            {
                
                for (int i = 0; i < this.lstObject.Count; i++)
                {
                    pMain = e.Location;
                    if (pMain.X >= lstObject[i].p1.X && pMain.Y <= lstObject[i].p1.Y && pMain.X <= lstObject[i].p2.X && pMain.Y >= lstObject[i].p2.Y)
                    {
                        this.lstObject.RemoveAt(i);
             
                       
                    }
                }
            }





        }

        private void pnMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isPress == true)
            {
                this.lstObject[this.lstObject.Count - 1].p2 = e.Location;
                this.pnMain.Refresh(); 
                
                
            }
           
            }

        private void pnMain_MouseUp(object sender, MouseEventArgs e)
        {
            this.isPress = false;
            this.lstObject[this.lstObject.Count - 1].p2 = e.Location;
            this.pnMain.Refresh();
            this.bLine = false;
            this.bEcllipse = false;
            this.bRect = false;
            this.bCircle = false;
            this.bFillEllipse = false;
            this.bRect = false;
            this.bFillCircle = false;  
            this.bPoly = false;
            this.bFillRect = false;
            this.bSelect = false;
        }

        private void pnMain_Click(object sender, EventArgs e)
        {
            

        }

        private void select_Click(object sender, EventArgs e)
        {
            this.bSelect = true;
        }
        private void red_Click(object sender, EventArgs e)
        {
            this.myColor= Color.Red; 
        }

        private void blue_Click(object sender, EventArgs e)
        {
            this.myColor = Color.Blue;
        }

        private void nhat_Click(object sender, EventArgs e)
        {
            this.width = 2.0F;
        }

        private void dam_Click(object sender, EventArgs e)
        {
            this.width = 4.0F;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            this.myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
        }

        private void solid_Click(object sender, EventArgs e)
        {
            this.myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        }

        private void Select_Click_1(object sender, EventArgs e)
        {
            bSelect = true;
        }
    }
   

    
}