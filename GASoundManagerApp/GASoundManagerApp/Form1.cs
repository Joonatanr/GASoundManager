using System.Media;

namespace GASoundManagerApp
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();


        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            wplayer.URL = "audio_clips/Test/MountainKing_edited2.mp3";
            wplayer.controls.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wplayer.URL = "audio_clips/Test/MorningMood_edited.mp3";
            wplayer.controls.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wplayer.URL = "audio_clips/Test/whip.mp3";
            wplayer.controls.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wplayer.URL = "audio_clips/Test/whip_x2.mp4";
            wplayer.controls.play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (wplayer.currentMedia != null)
            {
                labelPosition.Text = wplayer.controls.currentPositionString + "/" + wplayer.currentMedia.durationString;
            }

            trackBar1.Value = (int)wplayer.controls.currentPosition;
        }
    }
}
