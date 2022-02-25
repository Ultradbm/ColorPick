using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp1
{
    public partial class PickerForm : Form
    {

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        private Form1 parentWindow;
        public PickerForm(Form1 mainWindow)
        {

            
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            parentWindow = mainWindow; 
            this.TopMost = true;
            this.ResizeRedraw = true;
            
            InitializeComponent();
            this.TransparencyKey = Color.LavenderBlush;
            this.BackColor = Color.LavenderBlush;
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);
            DrawPolygonPointF(e);

        }

        public void DrawPolygonPointF(PaintEventArgs e)
        {
            //float centerX = 75.0f;
            //float centerY = 75.0f;
            float centerX = this.Size.Width/2;
            float centerY = this.Size.Height/2;

            Color pickedColor = parentWindow.GetColorAtMousePosition();
            Color markerColor = Color.FromArgb(0, 0, 0);
            if (pickedColor.R / 255 < .5 && pickedColor.G / 255 < .5 && pickedColor.B / 255 < .5) //if the background is dark, make the marker whites
            {
                markerColor = Color.FromArgb(255, 255, 255);
            }

            // Create pen.
            Pen drawPen = new Pen(Color.FromArgb(171, 166, 214), 1);
            SolidBrush solidBrush = new SolidBrush(pickedColor);

            PointF[] markerPoints = { new PointF(centerX+1, centerY+1), new PointF(centerX+10, centerY+10) };
            //PointF[] marker2Points = { new PointF(centerX + 3, centerY + 0), new PointF(centerX + 12, centerY + 9) };

            //Draw diagonal line near color source "marker"
            e.Graphics.DrawPolygon(new Pen(markerColor, 2.0f), markerPoints);
            //e.Graphics.DrawPolygon(new Pen(Color.Black, 2.0f), marker2Points);
  

            // Create points that define polygon.
            PointF point1 = new PointF(-73+centerX, 4+centerY);
            PointF point2 = new PointF(-41+centerX, 10+centerY);
            PointF point3 = new PointF(-23+centerX, 6+centerY);
            PointF point4 = new PointF(-23+centerX, -6+centerY);
            PointF point5 = new PointF(-40+centerX, -10+centerY);
            PointF point6 = new PointF(-73+centerX, -4+centerY);
            PointF point7 = new PointF(-73 + centerX, 4 + centerY);

            List<PointF> points = new List<PointF>();
            points.Add(point1);
            points.Add(point2);
            points.Add(point3);
            points.Add(point4);
            points.Add(point5);
            points.Add(point6);
            points.Add(point7);




            //    PointF center = new PointF(
            //points.Select(x => x.X).Max() +20,
            //(points.Select(x => x.Y).Max() + points.Select(x => x.Y).Min()) / 2);

            PointF center = new PointF(centerX, centerY);



            var state = e.Graphics.Save();

            //e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            e.Graphics.TranslateTransform(center.X, center.Y);
            //e.Graphics.RotateTransform(90);
            e.Graphics.TranslateTransform(-center.X, -center.Y);
            e.Graphics.FillPolygon(solidBrush, points.ToArray());
            e.Graphics.DrawPolygon(drawPen, points.ToArray());


            e.Graphics.TranslateTransform(center.X, center.Y);
            e.Graphics.RotateTransform(90);
            e.Graphics.TranslateTransform(-center.X, -center.Y);
            
            e.Graphics.FillPolygon(solidBrush, points.ToArray());
            e.Graphics.DrawPolygon(drawPen, points.ToArray());

            //e.Graphics.Restore(state);
            //e.Graphics.TranslateTransform(20, -20);


            e.Graphics.TranslateTransform(center.X, center.Y);
            e.Graphics.RotateTransform(90);
            e.Graphics.TranslateTransform(-center.X, -center.Y);
            //e.Graphics.TranslateTransform(10, );
            e.Graphics.FillPolygon(solidBrush, points.ToArray());
            e.Graphics.DrawPolygon(drawPen, points.ToArray());


            e.Graphics.TranslateTransform(center.X, center.Y);
            e.Graphics.RotateTransform(90);
            e.Graphics.TranslateTransform(-center.X, -center.Y);
            e.Graphics.FillPolygon(solidBrush, points.ToArray());
            e.Graphics.DrawPolygon(drawPen, points.ToArray());



            solidBrush.Dispose();
            drawPen.Dispose();
            //var state = e.Graphics.Save();
            //e.Graphics.DrawPolygon(Pens.DarkGreen, points.ToArray());
            //e.Graphics.Restore(state);
            //e.Graphics.RotateTransform(90);
            //e.Graphics.DrawPolygon(Pens.DarkGreen, points.ToArray());
            //e.Graphics.Restore(state);
            //e.Graphics.RotateTransform(180);
            //e.Graphics.DrawPolygon(Pens.DarkGreen, points.ToArray());

            //PointF point1 = new PointF();
            //PointF point1 = new PointF();
            //PointF point1 = new PointF();
            //PointF point1 = new PointF();
            //PointF point1 = new PointF();
            //PointF point1 = new PointF();
            //PointF point1 = new PointF();
            //PointF point1 = new PointF();
            //PointF point1 = new PointF();
            //PointF point1 = new PointF();
            //PointF point1 = new PointF();
            //PointF point1 = new PointF();
            //PointF point1 = new PointF();
            //PointF point1 = new PointF();
            //PointF point1 = new PointF();
            //PointF point1 = new PointF();
            //PointF point1 = new PointF();
            //PointF point1 = new PointF();

            //PointF point7 = new PointF(250.0F, 250.0F);
            //PointF[] curvePoints =
            //         {
            //     point1,
            //     point2,
            //     point3,
            //     point4,
            //     point5,
            //     point6,

            // };

            //// Draw polygon curve to screen.
            //e.Graphics.DrawPolygon(blackPen, curvePoints);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            //base.OnMouseMove(e);
            //this.Location = e.Location;
        }

        

        Point mousePosition = new Point();
        private void timer1_Tick(object sender, EventArgs e)
        {

            GetCursorPos(ref mousePosition);

            this.Location = new Point(mousePosition.X - this.Size.Width / 2, MousePosition.Y - this.Size.Height / 2);
            this.Refresh();
            //MessageBox.Show(this.Location +"");
        }


        private void PickerForm_Click(object sender, EventArgs e)
        {
            parentWindow.displayColor();
            Cursor.Show();
            //MessageBox.Show("hi");
        }

        protected override void OnClosed(EventArgs e)
        {

            parentWindow.reactivate();
            base.OnClosed(e);
        }

    }
}
