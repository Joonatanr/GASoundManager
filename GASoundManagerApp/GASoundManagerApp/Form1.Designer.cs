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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            buttonStop = new Button();
            buttonPause = new Button();
            buttonPlay = new Button();
            labelTrackName = new Label();
            labelPosition = new Label();
            trackBar1 = new TrackBar();
            groupBox2 = new GroupBox();
            button4 = new Button();
            trackBarVolume = new TrackBar();
            timer1 = new System.Windows.Forms.Timer(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            userControlAudioButtonList1 = new UserControlAudioButtonList();
            tabPage2 = new TabPage();
            richTextBoxDebug = new RichTextBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(buttonStop);
            groupBox1.Controls.Add(buttonPause);
            groupBox1.Controls.Add(buttonPlay);
            groupBox1.Controls.Add(labelTrackName);
            groupBox1.Controls.Add(labelPosition);
            groupBox1.Controls.Add(trackBar1);
            groupBox1.Location = new Point(14, 455);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(626, 172);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Track";
            // 
            // buttonStop
            // 
            buttonStop.Image = Properties.Resources.stop_button;
            buttonStop.Location = new Point(507, 19);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(94, 80);
            buttonStop.TabIndex = 5;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // buttonPause
            // 
            buttonPause.Image = Properties.Resources.pause_button;
            buttonPause.Location = new Point(407, 19);
            buttonPause.Name = "buttonPause";
            buttonPause.Size = new Size(94, 80);
            buttonPause.TabIndex = 4;
            buttonPause.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonPause.UseVisualStyleBackColor = true;
            buttonPause.Click += buttonPause_Click;
            // 
            // buttonPlay
            // 
            buttonPlay.BackColor = Color.Transparent;
            buttonPlay.Image = Properties.Resources.play_button;
            buttonPlay.Location = new Point(307, 19);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(94, 80);
            buttonPlay.TabIndex = 3;
            buttonPlay.UseVisualStyleBackColor = false;
            buttonPlay.Click += buttonPlay_Click;
            // 
            // labelTrackName
            // 
            labelTrackName.AutoSize = true;
            labelTrackName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            labelTrackName.Location = new Point(17, 31);
            labelTrackName.Name = "labelTrackName";
            labelTrackName.Size = new Size(185, 28);
            labelTrackName.TabIndex = 2;
            labelTrackName.Text = "<No track playing>";
            // 
            // labelPosition
            // 
            labelPosition.AutoSize = true;
            labelPosition.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 186);
            labelPosition.Location = new Point(18, 67);
            labelPosition.Name = "labelPosition";
            labelPosition.Size = new Size(65, 32);
            labelPosition.TabIndex = 1;
            labelPosition.Text = "--/--";
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trackBar1.Location = new Point(7, 101);
            trackBar1.Margin = new Padding(3, 4, 3, 4);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(613, 56);
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
            groupBox2.Location = new Point(647, 48);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(254, 579);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Volume";
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 186);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(87, 457);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(160, 115);
            button4.TabIndex = 1;
            button4.Text = "KILL VOLUME";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // trackBarVolume
            // 
            trackBarVolume.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            trackBarVolume.Location = new Point(29, 29);
            trackBarVolume.Margin = new Padding(3, 4, 3, 4);
            trackBarVolume.Maximum = 100;
            trackBarVolume.Name = "trackBarVolume";
            trackBarVolume.Orientation = Orientation.Vertical;
            trackBarVolume.Size = new Size(56, 542);
            trackBarVolume.TabIndex = 0;
            trackBarVolume.TickFrequency = 2;
            trackBarVolume.Value = 100;
            trackBarVolume.ValueChanged += trackBar2_ValueChanged;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(14, 16);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(626, 431);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Linen;
            tabPage1.Controls.Add(userControlAudioButtonList1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(618, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Test";
            // 
            // userControlAudioButtonList1
            // 
            userControlAudioButtonList1.AudioFiles = (List<string>)resources.GetObject("userControlAudioButtonList1.AudioFiles");
            userControlAudioButtonList1.Location = new Point(7, 4);
            userControlAudioButtonList1.Margin = new Padding(3, 5, 3, 5);
            userControlAudioButtonList1.Name = "userControlAudioButtonList1";
            userControlAudioButtonList1.Size = new Size(603, 319);
            userControlAudioButtonList1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(618, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBoxDebug
            // 
            richTextBoxDebug.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxDebug.Location = new Point(14, 635);
            richTextBoxDebug.Margin = new Padding(3, 4, 3, 4);
            richTextBoxDebug.Name = "richTextBoxDebug";
            richTextBoxDebug.Size = new Size(626, 165);
            richTextBoxDebug.TabIndex = 6;
            richTextBoxDebug.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(647, 635);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 818);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBoxDebug);
            Controls.Add(tabControl1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(932, 865);
            Name = "Form1";
            Text = "GA Estonian Evening Audio Player - 2024";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TrackBar trackBar1;
        private Label labelPosition;
        private System.Windows.Forms.Timer timer1;
        private Button button4;
        private TrackBar trackBarVolume;
        private Label labelTrackName;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private UserControlAudioButtonList userControlAudioButtonList1;
        private RichTextBox richTextBoxDebug;
        private PictureBox pictureBox1;
        private Button buttonPause;
        private Button buttonPlay;
        private Button buttonStop;
    }
}
