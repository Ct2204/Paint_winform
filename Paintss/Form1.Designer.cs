namespace Paintss
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.solid = new System.Windows.Forms.Label();
            this.dot = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dam = new System.Windows.Forms.Label();
            this.nhat = new System.Windows.Forms.Label();
            this.blue = new System.Windows.Forms.Label();
            this.red = new System.Windows.Forms.Label();
            this.btnCurve = new System.Windows.Forms.Button();
            this.btnFillRect = new System.Windows.Forms.Button();
            this.btnFillCircle = new System.Windows.Forms.Button();
            this.btnFillPoly = new System.Windows.Forms.Button();
            this.btnFillEllipse = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnPoly = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            this.btnEcllipse = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Location = new System.Drawing.Point(12, 148);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1322, 606);
            this.pnMain.TabIndex = 0;
            this.pnMain.Click += new System.EventHandler(this.pnMain_Click);
            this.pnMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMain_Paint);
            this.pnMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnMain_MouseDown);
            this.pnMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnMain_MouseMove);
            this.pnMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnMain_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Select);
            this.panel2.Controls.Add(this.solid);
            this.panel2.Controls.Add(this.dot);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dam);
            this.panel2.Controls.Add(this.nhat);
            this.panel2.Controls.Add(this.blue);
            this.panel2.Controls.Add(this.red);
            this.panel2.Controls.Add(this.btnCurve);
            this.panel2.Controls.Add(this.btnFillRect);
            this.panel2.Controls.Add(this.btnFillCircle);
            this.panel2.Controls.Add(this.btnFillPoly);
            this.panel2.Controls.Add(this.btnFillEllipse);
            this.panel2.Controls.Add(this.btnCircle);
            this.panel2.Controls.Add(this.btnPoly);
            this.panel2.Controls.Add(this.btnRect);
            this.panel2.Controls.Add(this.btnEcllipse);
            this.panel2.Controls.Add(this.btnLine);
            this.panel2.Location = new System.Drawing.Point(12, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1322, 125);
            this.panel2.TabIndex = 1;
            // 
            // solid
            // 
            this.solid.AutoSize = true;
            this.solid.Location = new System.Drawing.Point(1262, 54);
            this.solid.Name = "solid";
            this.solid.Size = new System.Drawing.Size(43, 20);
            this.solid.TabIndex = 23;
            this.solid.Text = "Solid";
            this.solid.Click += new System.EventHandler(this.solid_Click);
            // 
            // dot
            // 
            this.dot.AutoSize = true;
            this.dot.Location = new System.Drawing.Point(1222, 54);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(34, 20);
            this.dot.TabIndex = 21;
            this.dot.Text = "Dot";
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1067, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1205, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "DashStyle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(944, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Color";
            // 
            // dam
            // 
            this.dam.AutoSize = true;
            this.dam.Location = new System.Drawing.Point(1112, 37);
            this.dam.Name = "dam";
            this.dam.Size = new System.Drawing.Size(41, 20);
            this.dam.TabIndex = 16;
            this.dam.Text = "Đậm";
            this.dam.Click += new System.EventHandler(this.dam_Click);
            // 
            // nhat
            // 
            this.nhat.AutoSize = true;
            this.nhat.Location = new System.Drawing.Point(1046, 37);
            this.nhat.Name = "nhat";
            this.nhat.Size = new System.Drawing.Size(38, 20);
            this.nhat.TabIndex = 15;
            this.nhat.Text = "nhat";
            this.nhat.Click += new System.EventHandler(this.nhat_Click);
            // 
            // blue
            // 
            this.blue.AutoSize = true;
            this.blue.Location = new System.Drawing.Point(973, 37);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(38, 20);
            this.blue.TabIndex = 14;
            this.blue.Text = "blue";
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // red
            // 
            this.red.AutoSize = true;
            this.red.Location = new System.Drawing.Point(920, 37);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(35, 20);
            this.red.TabIndex = 13;
            this.red.Text = "Red";
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // btnCurve
            // 
            this.btnCurve.Location = new System.Drawing.Point(27, 71);
            this.btnCurve.Name = "btnCurve";
            this.btnCurve.Size = new System.Drawing.Size(94, 29);
            this.btnCurve.TabIndex = 12;
            this.btnCurve.Text = "Curve";
            this.btnCurve.UseVisualStyleBackColor = true;
            this.btnCurve.Click += new System.EventHandler(this.btnCurve_Click);
            // 
            // btnFillRect
            // 
            this.btnFillRect.Location = new System.Drawing.Point(253, 71);
            this.btnFillRect.Name = "btnFillRect";
            this.btnFillRect.Size = new System.Drawing.Size(94, 29);
            this.btnFillRect.TabIndex = 11;
            this.btnFillRect.Text = "Fill Rect";
            this.btnFillRect.UseVisualStyleBackColor = true;
            this.btnFillRect.Click += new System.EventHandler(this.btnFillRect_Click);
            // 
            // btnFillCircle
            // 
            this.btnFillCircle.Location = new System.Drawing.Point(364, 71);
            this.btnFillCircle.Name = "btnFillCircle";
            this.btnFillCircle.Size = new System.Drawing.Size(94, 29);
            this.btnFillCircle.TabIndex = 10;
            this.btnFillCircle.Text = "Fill Circle";
            this.btnFillCircle.UseVisualStyleBackColor = true;
            this.btnFillCircle.Click += new System.EventHandler(this.btnFillCircle_Click);
            // 
            // btnFillPoly
            // 
            this.btnFillPoly.Location = new System.Drawing.Point(480, 71);
            this.btnFillPoly.Name = "btnFillPoly";
            this.btnFillPoly.Size = new System.Drawing.Size(94, 29);
            this.btnFillPoly.TabIndex = 9;
            this.btnFillPoly.Text = "Fill Polygon";
            this.btnFillPoly.UseVisualStyleBackColor = true;
            this.btnFillPoly.Click += new System.EventHandler(this.btnFillPoly_Click);
            // 
            // btnFillEllipse
            // 
            this.btnFillEllipse.Location = new System.Drawing.Point(138, 71);
            this.btnFillEllipse.Name = "btnFillEllipse";
            this.btnFillEllipse.Size = new System.Drawing.Size(94, 29);
            this.btnFillEllipse.TabIndex = 8;
            this.btnFillEllipse.Text = "Fill Ellipse";
            this.btnFillEllipse.UseVisualStyleBackColor = true;
            this.btnFillEllipse.Click += new System.EventHandler(this.btnFillEllipse_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(364, 17);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(94, 29);
            this.btnCircle.TabIndex = 7;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnPoly
            // 
            this.btnPoly.Location = new System.Drawing.Point(480, 17);
            this.btnPoly.Name = "btnPoly";
            this.btnPoly.Size = new System.Drawing.Size(94, 29);
            this.btnPoly.TabIndex = 6;
            this.btnPoly.Text = "Polygon";
            this.btnPoly.UseVisualStyleBackColor = true;
            this.btnPoly.Click += new System.EventHandler(this.btnPoly_Click);
            // 
            // btnRect
            // 
            this.btnRect.Location = new System.Drawing.Point(253, 17);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(94, 29);
            this.btnRect.TabIndex = 2;
            this.btnRect.Text = "Rectangle";
            this.btnRect.UseVisualStyleBackColor = true;
            this.btnRect.Click += new System.EventHandler(this.btnRect_Click);
            // 
            // btnEcllipse
            // 
            this.btnEcllipse.Location = new System.Drawing.Point(138, 17);
            this.btnEcllipse.Name = "btnEcllipse";
            this.btnEcllipse.Size = new System.Drawing.Size(94, 29);
            this.btnEcllipse.TabIndex = 1;
            this.btnEcllipse.Text = "Ecllipse";
            this.btnEcllipse.UseVisualStyleBackColor = true;
            this.btnEcllipse.Click += new System.EventHandler(this.btnEcllipse_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(27, 17);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(94, 29);
            this.btnLine.TabIndex = 0;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // Select
            // 
            this.Select.AutoSize = true;
            this.Select.Location = new System.Drawing.Point(719, 17);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(49, 20);
            this.Select.TabIndex = 24;
            this.Select.Text = "Select";
            this.Select.UseMnemonic = false;
            this.Select.Click += new System.EventHandler(this.Select_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 766);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnMain;
        private Panel panel2;
        private Button btnRect;
        private Button btnEcllipse;
        private Button btnLine;
        private Button btnPoly;
        private Button btnFillRect;
        private Button btnFillCircle;
        private Button btnFillPoly;
        private Button btnFillEllipse;
        private Button btnCircle;
        private Button btnCurve;
        private Label blue;
        private Label red;
        private Label dam;
        private Label nhat;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label dot;
        private Label solid;
        private Label Select;
    }
}