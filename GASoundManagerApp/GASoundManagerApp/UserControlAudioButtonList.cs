using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GASoundManagerApp
{
    public partial class UserControlAudioButtonList : UserControl
    {
        private List<string> audioFiles = new List<string>();
        private Dictionary<string, string> myAudioFilesDictionary = new Dictionary<string, string>();

        public delegate void AudioFilePlayedHandler(string filepath);
        public AudioFilePlayedHandler AudioFilePlayed = null;

        public List<string> AudioFiles 
        { 
            get 
            { 
                return audioFiles; 
            }

            set
            {
                audioFiles = value;
                updateButtons();
            }
        }

        
        public UserControlAudioButtonList()
        {
            InitializeComponent();
        }

        private void updateButtons()
        {
            AudioButtonsGroupBox.Controls.Clear();
            myAudioFilesDictionary.Clear();

            /* TODO : Make this as dynamic as possible. */
            int yLoc = 20;
            int xLoc = 10;

            foreach (string filePath in audioFiles)
            {
                if (File.Exists(filePath))
                {
                    string fileName = Path.GetFileName(filePath);
                    myAudioFilesDictionary.Add(fileName, filePath);

                    Button myButton = new Button();
                    myButton.Text = fileName;
                    myButton.Click += MyButton_Click;
                    myButton.Size = new Size(150, 60);

                    myButton.Location = new Point(xLoc, yLoc);
                    myButton.BackColor = Color.Beige;

                    yLoc += 10;
                    yLoc += myButton.Height;

                    if ((yLoc + myButton.Height) > this.Height)
                    {
                        yLoc = 20;
                        xLoc += 10;
                        xLoc += myButton.Width;
                    }

                    AudioButtonsGroupBox.Controls.Add(myButton);
                }
            }
        }

        private void MyButton_Click(object? sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;
                string s = btn.Text;
                string filePath = myAudioFilesDictionary[s];
                if (filePath != null)
                {
                    AudioFilePlayed?.Invoke(filePath);
                }
            }
            catch (Exception)
            {
                /* TODO : Report error */
            }
        }
    }
}
