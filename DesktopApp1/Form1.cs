using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



using System.Drawing.Imaging;
using System.Runtime.InteropServices;

using System.Diagnostics;
using System.Threading;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp1
{
    public partial class Form1 : Form, IMessageFilter
    {
        private Color backColor = Color.FromArgb(43, 44, 47);
        private Color foreColor = Color.FromArgb(171, 166, 214);
        private Color disabledBackColor = Color.FromArgb(23, 24, 27);
        private Color disabledForeColor = Color.FromArgb(111, 106, 154);
        private bool isActive = false; //are we picking colors right now?
        private const int paletteAmount = 10;

        PickerForm pickerForm;

        //private int paletteTracker = 0;   Was for keeping track where on the palette the color should be added, but now we always add to the leftmost [0]
        //private string rgbVal;
        //private string hexVal;

        //Window Handle Stuff
        //private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        //private const UInt32 SWP_NOSIZE = 0x0001;
        //private const UInt32 SWP_NOMOVE = 0x0002;
        //private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        //[DllImport("user32.dll")]
        //public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);



        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

        public Form1()
        {
            pickerForm = new PickerForm(this);

            this.TopMost = true;
            InitializeComponent();

            Application.AddMessageFilter(this);
            this.FormClosed += delegate { Application.RemoveMessageFilter(this); };


            //not sure why these three lines are here again, remember it solved something at a time but don't seem to do anything now
            this.color1Button.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            this.color2Button.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            this.color2Button.FlatAppearance.BorderSize = 0;


            //this is so we set all the hover/press colors also to black
            updateColorBoxColor(this.color1Button, Color.Black);
            updateColorBoxColor(this.color2Button, Color.Black);
                


            for (int i = 0; i < paletteAmount; i++)
            {
                PictureBox newPictureBox = new PictureBox();
                //newButton.FlatAppearance.BorderSize = 0;
                //newButton.FlatStyle = FlatStyle.Flat;

                //Make sure width of flow layout panel is a multiple of palette amount + 2 (to account for border size)
                newPictureBox.Size = new Size((this.flowLayoutPanel1.Size.Width-2) / paletteAmount, this.flowLayoutPanel1.Size.Height);
                newPictureBox.Margin = new Padding(0);
                newPictureBox.Padding = new Padding(0);
                //newButton.BackColor = Color.FromArgb(i*100/paletteAmount,i*100/paletteAmount,i*100/paletteAmount);
                newPictureBox.BackColor = Color.Transparent;
                //newButton.FlatAppearance.MouseOverBackColor = newButton.BackColor;
                newPictureBox.Click += new EventHandler(paletteButton_Click_Handler);
                newPictureBox.TabStop = false;
                this.flowLayoutPanel1.Controls.Add(newPictureBox);
            }

            //foreach (var control in this.Controls)
            //{
            //    //((Control)control).TabStop = false;
            //    if ((control as Button) != null && (control as Button) != this.PickColorButton)
            //    {
            //        ((Button)control).FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            //    }
            //}
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Tab)
            {
                //MessageBox.Show("tab");
                //MessageBox.Show("" + color2Button.Focused);
                //this.ActiveControl = rgbLabel;

                //return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }



        protected override void OnKeyDown(KeyEventArgs e)
        {
            MessageBox.Show(e + "");
            base.OnKeyDown(e);
        }

        protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        {
            MessageBox.Show(e.ToString());
            base.OnPreviewKeyDown(e);
        }
        
        protected override void OnTabIndexChanged(EventArgs e)
        {
            MessageBox.Show(e.ToString());
            base.OnTabStopChanged(e);
        }

        private void paletteButton_Click_Handler(object sender, System.EventArgs e)
        {
            //MessageBox.Show(((Control)sender).BackColor.ToString());
            Color color = ((Control)sender).BackColor;
            updateColorBoxColor(color1Button, color);
            updateColorBoxColor(color2Button, color);
            updateColorStrings(color);
        }


        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }
        //private void MouseMoveTimer_Tick(object sender, EventArgs e)
        //{


        //    MessageBox.Show("Blue");
        //    Point cursor = new Point();
        //    GetCursorPos(ref cursor);

        //    var c = GetColorAt(cursor);
        //    this.BackColor = c;

        //    if (c.R == c.G && c.G < 64 && c.B > 128)
        //    {
        //        MessageBox.Show("Blue");
        //    }
        //}


        Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);


        Point mousePosition = new Point(); //updated in tick event function

        public Color GetColorAtMousePosition()
        {
            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, mousePosition.X, mousePosition.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }

            return screenPixel.GetPixel(0, 0);
        }




        public void displayColor()
        {
            if (isActive)
            {
                Color color = GetColorAtMousePosition();

                updateColorBoxColor(this.color1Button, color);

                updateColorStrings(color);
               
                updatePalette(color);
                //paletteTracker++;


                isActive = false;
                pickerForm.Close();
            }
            //MessageBox.Show(color.R.ToString("X2")+color.G.ToString("X2")+color.B.ToString("X2"));
        }

       public void reactivate()
        {
            //isActive = true; should be false
            this.PickColorButton.Enabled = true;
        }

        private string rgbCode = "rgb(0, 0, 0)";
        private string hexCode = "000000";
        private void updateColorStrings(Color color)
        {
            rgbCode = $"rgb({color.R.ToString()}, {color.G.ToString()}, {color.B.ToString()})";
            hexCode = color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
            rgbLabel.Text = "RGB: " + rgbCode;
            hexLabel.Text = "HEX: #" + hexCode;
        }


        public void updatePalette(Color color)
        {
            //look into AS keyword for casting and look into error handling  ------------ look into AS keyword as opposed to casting

            //move current palette colors over to the right
            bool shouldAdd = true;
            int existsIndex = 0;
            for (int i = 0; i < paletteAmount; i++)
            {
                if(color == this.flowLayoutPanel1.Controls[i].BackColor)
                {
                    shouldAdd = false;
                    existsIndex = i;
                }
            }

            if (shouldAdd)
            {
                for (int i = paletteAmount - 1; i > 0; i--)
                { //only need to cast when accessing flatappearance
                  //this.flowLayoutPanel1.Controls[i].BackColor = ((Button)this.flowLayoutPanel1.Controls[i - 1]).BackColor;
                  //((Button)this.flowLayoutPanel1.Controls[i]).FlatAppearance.MouseOverBackColor = this.flowLayoutPanel1.Controls[i - 1].BackColor;
                    this.flowLayoutPanel1.Controls[i].BackColor = this.flowLayoutPanel1.Controls[i - 1].BackColor;
                    
                }


                //update leftmost color
                this.flowLayoutPanel1.Controls[0].BackColor = color;
                //((Button)this.flowLayoutPanel1.Controls[0]).FlatAppearance.MouseOverBackColor = color;
            }
            else
            {
                for(int i = existsIndex; i > 0; i--)
                {
                    this.flowLayoutPanel1.Controls[i].BackColor = this.flowLayoutPanel1.Controls[i - 1].BackColor;
                    //((Button)this.flowLayoutPanel1.Controls[i]).FlatAppearance.MouseOverBackColor = this.flowLayoutPanel1.Controls[i - 1].BackColor;
                }
                this.flowLayoutPanel1.Controls[0].BackColor = color;
                //((Button)this.flowLayoutPanel1.Controls[0]).FlatAppearance.MouseOverBackColor = color;
            }
        }


        private void Timer1_Tick(object Sender, EventArgs e)
        {
            // Set the caption to the current time.  
            GetCursorPos(ref mousePosition);
            if (isActive)
            {
                //GetCursorPos(ref mousePosition);
                updateColorBoxColor(this.color2Button, GetColorAtMousePosition());
                
            }
        }


        // deleted timer2
        //private void timer2_Tick(object sender, EventArgs e) 
        //{

        //    //Rectangle BoundRect = new Rectangle(this.PickColorButton.PointToScreen(Point.Empty).X - 1, this.PickColorButton.PointToScreen(Point.Empty).Y - 1, 1, 1);
        //    //Cursor.Clip = BoundRect;
        //    //this.Cursor = new Cursor(Cursor.Current.Handle);
        //    //Cursor.Position = this.PickColorButton.PointToScreen(Point.Empty);

        //}

        //protected override void OnMouseMove(MouseEventArgs e)
        //{
        //    Cursor.Hide();
        //}

        private void updateColorBoxColor(Button box, Color color)
        {
            box.BackColor = color;
            box.FlatAppearance.MouseOverBackColor = this.color2Button.BackColor;
            box.FlatAppearance.MouseDownBackColor = this.color2Button.BackColor;
        }

        //private void Form1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    displayColor();
        //    color1Button.BackColor = GetColorAtMousePosition();
        //}

        // handle clicks application wide
        //private Point simulatedMousePos;
        public bool PreFilterMessage(ref Message m)
        {
            if(m.Msg == 0x200)
            {
                //MessageBox.Show(m.Msg + "");
            }
            if (m.Msg == 0x201)
            {
                // don't want to pick color inside of app so commented out
                //displayColor();

            }
            return false;
        }

        // handle clicks outside window
        
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            //if (isActive)
            //{
            //    this.Activate();
            //}
            //displayColor();
        }




        //private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    // Click on the link below to continue learning how to build a desktop app using WinForms!
        //    System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        //}




        private void color1Button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Thanks!");
            //button1.BackColor = GetColorAtMousePosition();
            //displayColor();
        }


        

        private void sticky_Toggled(object sender, EventArgs e)
        {
            if (this.TopMost) //if enabled
             {
                //disable
                this.TopMost = false;
                //this.StickyToggle.BackColor = disabledBackColor;
                this.StickyToggle.ForeColor = disabledForeColor;
            }
            else
            {
                //enable
                this.TopMost = true;
                this.StickyToggle.BackColor = backColor;
                this.StickyToggle.ForeColor = foreColor;
            }

        }


      



        private void pickColorButton_Click(object sender, EventArgs e)
        {
            isActive = true;
            this.PickColorButton.Enabled = false;

            Cursor.Hide();
            GetCursorPos(ref mousePosition);
            pickerForm = new PickerForm(this);
            pickerForm.Location = new Point(mousePosition.X - this.Size.Width / 2, MousePosition.Y - this.Size.Height / 2);
            pickerForm.Show();
            pickerForm.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void PickColorButton_EnabledChanged(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = ((Button)sender).Enabled ? Color.FromArgb(171, 166, 214) : Color.White;
            ((Button)sender).BackColor = Color.FromArgb(47, 47, 57);
            //171, 166, 214
            //47, 47, 57
        }


        //implement draw function to enable drawing of custom colors
        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        private void CopyRGB_Click(object sender, EventArgs e)
        {
            //FadeIn(CopyNotif_RGB, 1000);
            //slideInHorizontal(CopyNotif_RGB, 1);
            slideInRGBHorizontal(CopyNotif_RGB, 1);

            //CopyNotif_RGB.ForeColor = foreColor;

            Clipboard.SetText(rgbCode);
        }
        private void CopyHEX_Click(object sender, EventArgs e)
        {
            slideInHexHorizontal(CopyNotif_Hex, 1);
            Clipboard.SetText(hexCode);
        }


        private void tabBreaksEverythingWorkaround_Button_Fix(object sender, EventArgs e)
        {
            this.ActiveControl = rgbLabel;
        }

        private async void FadeIn(Label label, int interval = 80)
        {
            //Object is not fully invisible. Fade it in
            int r = label.ForeColor.R;
            int g = label.ForeColor.G;
            int b = label.ForeColor.B;

            while (label.ForeColor != foreColor)
            {
                await Task.Delay(interval);

                label.ForeColor = Color.FromArgb((int)lerp(r, foreColor.R, .1f), (int)lerp(g, foreColor.G, .1f), (int)lerp(b, foreColor.B, .1f)); //make fully visible       


                //label.ForeColor = Color.FromArgb(tempAlpha, 255, 255, 255);
            }
            label.ForeColor = ForeColor; //make fully visible       

        }

        //CancellationTokenSource cancelTokenSource;
        //private async void slideInHorizontal(Label label, int interval = 1)
        //{
        //    label.Left = -60;

        //    while (label.Left < 5)
        //    {
        //        await Task.Delay(1);
        //        label.Left = label.Left + 5;
        //    }

        //    //if(shouldCancel == true)
        //    //{
        //    //    cancelToken.Cancel();
        //    //}
        //    //shouldCancel = true;
        //    try
        //    {
        //        cancelTokenSource?.Cancel();
        //        cancelTokenSource = new CancellationTokenSource();
        //        await Task.Delay(1000, cancelTokenSource.Token);
        //        label.Left = -60;
        //    }
        //    catch (TaskCanceledException)
        //    {

        //    }
        //    catch (Exception e)
        //    {
        //        Debug.WriteLine(e);
        //    }
        //    //shouldCancel = false;
        //}

        CancellationTokenSource cancelTokenSource;
        private async void slideInRGBHorizontal(Label label, int interval = 1)
        {
            label.Left = -60;

            while (label.Left < 5)
            {
                await Task.Delay(1);
                label.Left = label.Left + 5;
            }

            //if(shouldCancel == true)
            //{
            //    cancelToken.Cancel();
            //}
            //shouldCancel = true;
            try
            {
                cancelTokenSource?.Cancel();
                cancelTokenSource = new CancellationTokenSource();
                await Task.Delay(1000, cancelTokenSource.Token);
                label.Left = -60;
            }
            catch (TaskCanceledException)
            {

            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
            //shouldCancel = false;
        }

        CancellationTokenSource cancelTokenSource2;
        private async void slideInHexHorizontal(Label label, int interval = 1)
        {
            label.Left = -60;

            while (label.Left < 5)
            {
                await Task.Delay(1);
                label.Left = label.Left + 5;
            }

            //if(shouldCancel == true)
            //{
            //    cancelToken.Cancel();
            //}
            //shouldCancel = true;
            try
            {
                cancelTokenSource2?.Cancel();
                cancelTokenSource2 = new CancellationTokenSource();
                await Task.Delay(1000, cancelTokenSource2.Token);
                label.Left = -60;
            }
            catch (TaskCanceledException)
            {

            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
            //shouldCancel = false;
        }

        private int lerp(float a, float b, float f)
        {
            return (int)Math.Ceiling(((a * (1.0f - f)) + (b * f)));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
