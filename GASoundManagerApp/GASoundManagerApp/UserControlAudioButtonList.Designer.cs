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
            AudioButtonsGroupBox.AutoSize = true;
            AudioButtonsGroupBox.Location = new Point(3, 3);
            AudioButtonsGroupBox.Name = "AudioButtonsGroupBox";
            AudioButtonsGroupBox.Size = new Size(313, 284);
            AudioButtonsGroupBox.TabIndex = 0;
            AudioButtonsGroupBox.TabStop = false;
            AudioButtonsGroupBox.Text = "Audio Files";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(AudioButtonsGroupBox);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 290);
            panel1.TabIndex = 0;
            // 
            // UserControlAudioButtonList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UserControlAudioButtonList";
            Size = new Size(325, 296);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox AudioButtonsGroupBox;
        private Panel panel1;
    }
}
