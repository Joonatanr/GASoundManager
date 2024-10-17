namespace GASoundManagerApp
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
            components = new System.ComponentModel.Container();
            buttonPlay = new Button();
            groupBox1 = new GroupBox();
            labelTrackName = new Label();
            labelPosition = new Label();
            trackBar1 = new TrackBar();
            groupBox2 = new GroupBox();
            button4 = new Button();
            trackBarVolume = new TrackBar();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).BeginInit();
            SuspendLayout();
            // 
            // buttonPlay
            // 
            buttonPlay.Location = new Point(12, 12);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(126, 41);
            buttonPlay.TabIndex = 0;
            buttonPlay.Text = "Play 1";
            buttonPlay.UseVisualStyleBackColor = true;
            buttonPlay.Click += buttonPlay_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(labelTrackName);
            groupBox1.Controls.Add(labelPosition);
            groupBox1.Controls.Add(trackBar1);
            groupBox1.Location = new Point(12, 294);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(548, 144);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Track";
            // 
            // labelTrackName
            // 
            labelTrackName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTrackName.AutoSize = true;
            labelTrackName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            labelTrackName.Location = new Point(15, 23);
            labelTrackName.Name = "labelTrackName";
            labelTrackName.Size = new Size(146, 21);
            labelTrackName.TabIndex = 2;
            labelTrackName.Text = "<No track playing>";
            // 
            // labelPosition
            // 
            labelPosition.AutoSize = true;
            labelPosition.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 186);
            labelPosition.Location = new Point(16, 50);
            labelPosition.Name = "labelPosition";
            labelPosition.Size = new Size(52, 25);
            labelPosition.TabIndex = 1;
            labelPosition.Text = "--/--";
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trackBar1.Location = new Point(6, 83);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(536, 45);
            trackBar1.TabIndex = 0;
            trackBar1.Scroll += trackBar1_Scroll;
            trackBar1.MouseDown += trackBar1_MouseDown;
            trackBar1.MouseUp += trackBar1_MouseUp;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(trackBarVolume);
            groupBox2.Location = new Point(566, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(222, 426);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Volume";
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 186);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(76, 334);
            button4.Name = "button4";
            button4.Size = new Size(140, 86);
            button4.TabIndex = 1;
            button4.Text = "KILL VOLUME";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // trackBarVolume
            // 
            trackBarVolume.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            trackBarVolume.Location = new Point(25, 22);
            trackBarVolume.Maximum = 100;
            trackBarVolume.Name = "trackBarVolume";
            trackBarVolume.Orientation = Orientation.Vertical;
            trackBarVolume.Size = new Size(45, 398);
            trackBarVolume.TabIndex = 0;
            trackBarVolume.TickFrequency = 2;
            trackBarVolume.Value = 100;
            trackBarVolume.ValueChanged += trackBar2_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 59);
            button1.Name = "button1";
            button1.Size = new Size(126, 41);
            button1.TabIndex = 2;
            button1.Text = "Play 2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 118);
            button2.Name = "button2";
            button2.Size = new Size(126, 44);
            button2.TabIndex = 3;
            button2.Text = "Whip 1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 168);
            button3.Name = "button3";
            button3.Size = new Size(126, 44);
            button3.TabIndex = 4;
            button3.Text = "Whip 2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonPlay);
            MinimumSize = new Size(420, 420);
            Name = "Form1";
            Text = "GA Estonian Evening Audio Player";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonPlay;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private TrackBar trackBar1;
        private Label labelPosition;
        private System.Windows.Forms.Timer timer1;
        private Button button4;
        private TrackBar trackBarVolume;
        private Label labelTrackName;
    }
}
