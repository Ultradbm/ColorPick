namespace DesktopApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.color1Button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rgbLabel = new System.Windows.Forms.Label();
            this.hexLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.color2Button = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PickColorButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CopyButton = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.StickyToggle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rgbCopyPanel = new System.Windows.Forms.Panel();
            this.CopyNotif_RGB = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CopyNotif_Hex = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CopyButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.rgbCopyPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // color1Button
            // 
            this.color1Button.BackColor = System.Drawing.SystemColors.ControlText;
            this.color1Button.FlatAppearance.BorderSize = 0;
            this.color1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color1Button.Location = new System.Drawing.Point(0, -1);
            this.color1Button.Margin = new System.Windows.Forms.Padding(0);
            this.color1Button.Name = "color1Button";
            this.color1Button.Size = new System.Drawing.Size(39, 117);
            this.color1Button.TabIndex = 2;
            this.color1Button.TabStop = false;
            this.color1Button.UseVisualStyleBackColor = false;
            this.color1Button.Click += new System.EventHandler(this.color1Button_Click);
            this.color1Button.Enter += new System.EventHandler(this.tabBreaksEverythingWorkaround_Button_Fix);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // rgbLabel
            // 
            this.rgbLabel.AutoSize = true;
            this.rgbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.rgbLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(166)))), ((int)(((byte)(214)))));
            this.rgbLabel.Location = new System.Drawing.Point(12, 9);
            this.rgbLabel.Name = "rgbLabel";
            this.rgbLabel.Size = new System.Drawing.Size(177, 26);
            this.rgbLabel.TabIndex = 3;
            this.rgbLabel.Text = "RGB: rgb(0, 0, 0)";
            this.rgbLabel.Click += new System.EventHandler(this.CopyRGB_Click);
            // 
            // hexLabel
            // 
            this.hexLabel.AutoSize = true;
            this.hexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.hexLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(166)))), ((int)(((byte)(214)))));
            this.hexLabel.Location = new System.Drawing.Point(12, 45);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(154, 26);
            this.hexLabel.TabIndex = 4;
            this.hexLabel.Text = "HEX: #000000";
            this.hexLabel.Click += new System.EventHandler(this.CopyHEX_Click);
            // 
            // color2Button
            // 
            this.color2Button.BackColor = System.Drawing.SystemColors.ControlText;
            this.color2Button.FlatAppearance.BorderSize = 0;
            this.color2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color2Button.Location = new System.Drawing.Point(39, 0);
            this.color2Button.Margin = new System.Windows.Forms.Padding(0);
            this.color2Button.Name = "color2Button";
            this.color2Button.Size = new System.Drawing.Size(239, 116);
            this.color2Button.TabIndex = 6;
            this.color2Button.TabStop = false;
            this.color2Button.UseVisualStyleBackColor = false;
            this.color2Button.Enter += new System.EventHandler(this.tabBreaksEverythingWorkaround_Button_Fix);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Coral;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 224);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(422, 44);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // PickColorButton
            // 
            this.PickColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.PickColorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.PickColorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.PickColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PickColorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(166)))), ((int)(((byte)(214)))));
            this.PickColorButton.Location = new System.Drawing.Point(314, 84);
            this.PickColorButton.Name = "PickColorButton";
            this.PickColorButton.Size = new System.Drawing.Size(125, 116);
            this.PickColorButton.TabIndex = 8;
            this.PickColorButton.Text = "Pick Color";
            this.PickColorButton.UseVisualStyleBackColor = false;
            this.PickColorButton.EnabledChanged += new System.EventHandler(this.PickColorButton_EnabledChanged);
            this.PickColorButton.Click += new System.EventHandler(this.pickColorButton_Click);
            this.PickColorButton.Enter += new System.EventHandler(this.tabBreaksEverythingWorkaround_Button_Fix);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.color2Button);
            this.panel1.Controls.Add(this.color1Button);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(166)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(17, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 116);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pictureBox1.Location = new System.Drawing.Point(18, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 44);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyButton.Image")));
            this.CopyButton.Location = new System.Drawing.Point(266, 9);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(31, 26);
            this.CopyButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CopyButton.TabIndex = 12;
            this.CopyButton.TabStop = false;
            this.toolTip1.SetToolTip(this.CopyButton, "Copy to clipboard");
            this.CopyButton.Click += new System.EventHandler(this.CopyRGB_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.BackColor = System.Drawing.Color.Black;
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            this.toolTip1.InitialDelay = 1000;
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(266, 45);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Copy to clipboard");
            this.pictureBox3.Click += new System.EventHandler(this.CopyHEX_Click);
            // 
            // StickyToggle
            // 
            this.StickyToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StickyToggle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(166)))), ((int)(((byte)(214)))));
            this.StickyToggle.Location = new System.Drawing.Point(385, 9);
            this.StickyToggle.Name = "StickyToggle";
            this.StickyToggle.Size = new System.Drawing.Size(54, 23);
            this.StickyToggle.TabIndex = 14;
            this.StickyToggle.TabStop = false;
            this.StickyToggle.Text = "Sticky";
            this.toolTip1.SetToolTip(this.StickyToggle, "Stick window on top of other windows");
            this.StickyToggle.UseVisualStyleBackColor = true;
            this.StickyToggle.Click += new System.EventHandler(this.sticky_Toggled);
            this.StickyToggle.Enter += new System.EventHandler(this.tabBreaksEverythingWorkaround_Button_Fix);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(14, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 34);
            this.panel2.TabIndex = 15;
            this.panel2.Click += new System.EventHandler(this.CopyRGB_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(14, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(286, 34);
            this.panel3.TabIndex = 16;
            this.panel3.Click += new System.EventHandler(this.CopyHEX_Click);
            // 
            // rgbCopyPanel
            // 
            this.rgbCopyPanel.Controls.Add(this.CopyNotif_RGB);
            this.rgbCopyPanel.Location = new System.Drawing.Point(306, 5);
            this.rgbCopyPanel.Name = "rgbCopyPanel";
            this.rgbCopyPanel.Size = new System.Drawing.Size(73, 34);
            this.rgbCopyPanel.TabIndex = 0;
            // 
            // CopyNotif_RGB
            // 
            this.CopyNotif_RGB.AutoSize = true;
            this.CopyNotif_RGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyNotif_RGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(166)))), ((int)(((byte)(214)))));
            this.CopyNotif_RGB.Location = new System.Drawing.Point(-60, 8);
            this.CopyNotif_RGB.Name = "CopyNotif_RGB";
            this.CopyNotif_RGB.Size = new System.Drawing.Size(63, 20);
            this.CopyNotif_RGB.TabIndex = 0;
            this.CopyNotif_RGB.Text = "Copied!";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.CopyNotif_Hex);
            this.panel4.Location = new System.Drawing.Point(306, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(73, 34);
            this.panel4.TabIndex = 17;
            // 
            // CopyNotif_Hex
            // 
            this.CopyNotif_Hex.AutoSize = true;
            this.CopyNotif_Hex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyNotif_Hex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(166)))), ((int)(((byte)(214)))));
            this.CopyNotif_Hex.Location = new System.Drawing.Point(-60, 8);
            this.CopyNotif_Hex.Name = "CopyNotif_Hex";
            this.CopyNotif_Hex.Size = new System.Drawing.Size(63, 20);
            this.CopyNotif_Hex.TabIndex = 0;
            this.CopyNotif_Hex.Text = "Copied!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(462, 286);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.rgbCopyPanel);
            this.Controls.Add(this.StickyToggle);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PickColorButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.hexLabel);
            this.Controls.Add(this.rgbLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Type:Start ColorPick";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CopyButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.rgbCopyPanel.ResumeLayout(false);
            this.rgbCopyPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button color1Button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label rgbLabel;
        private System.Windows.Forms.Label hexLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button color2Button;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button PickColorButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox CopyButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button StickyToggle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel rgbCopyPanel;
        private System.Windows.Forms.Label CopyNotif_RGB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label CopyNotif_Hex;
    }
}

