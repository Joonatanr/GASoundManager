namespace GASoundManagerApp
{
    partial class UserControlAudioButtonList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AudioButtonsGroupBox = new GroupBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AudioButtonsGroupBox
            // 
            AudioButtonsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AudioButtonsGroupBox.Location = new Point(3, 4);
            AudioButtonsGroupBox.Margin = new Padding(3, 4, 3, 4);
            AudioButtonsGroupBox.Name = "AudioButtonsGroupBox";
            AudioButtonsGroupBox.Padding = new Padding(3, 4, 3, 4);
            AudioButtonsGroupBox.Size = new Size(358, 379);
            AudioButtonsGroupBox.TabIndex = 0;
            AudioButtonsGroupBox.TabStop = false;
            AudioButtonsGroupBox.Text = "Audio Files";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(AudioButtonsGroupBox);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 387);
            panel1.TabIndex = 0;
            // 
            // UserControlAudioButtonList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlAudioButtonList";
            Size = new Size(371, 395);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox AudioButtonsGroupBox;
        private Panel panel1;
    }
}
