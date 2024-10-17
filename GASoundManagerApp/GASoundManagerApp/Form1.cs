using System.Media;

namespace GASoundManagerApp
{
    public partial class Form1 : Form
    {
        private WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        private bool isUserUpdatingTrackbar = false;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();

            wplayer.MediaChange += Wplayer_MediaChange;
        }

        private void Wplayer_MediaChange(object Item)
        {
            trackBar1.Maximum = (int)wplayer.currentMedia.duration;
            labelTrackName.Text = wplayer.currentMedia.name;
        }

        private void playAudio(string path)
        {
            try
            {
                wplayer.controls.stop();
                wplayer.URL = path;
                wplayer.controls.play();
            }
            catch (Exception ex)
            {
                /* TODO : Report error. */
            }
        }

        private void setPositionString(double currLoc, double duration)
        {
            var curr = TimeSpan.FromSeconds(currLoc);
            var dur = TimeSpan.FromSeconds(duration);

            labelPosition.Text = curr.ToString(@"mm\:ss") + " / " + dur.ToString(@"mm\:ss");
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            playAudio("audio_clips/Test/MountainKing_edited2.mp3");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playAudio("audio_clips/Test/MorningMood_edited.mp3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playAudio("audio_clips/Test/whip.mp3");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            playAudio("audio_clips/Test/whip_x2.mp4");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (wplayer.currentMedia != null)
            {
                setPositionString(wplayer.controls.currentPosition, wplayer.currentMedia.duration);

                if (!isUserUpdatingTrackbar)
                {
                    trackBar1.Value = (int)wplayer.controls.currentPosition;
                }
            }
        }


        private void trackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            isUserUpdatingTrackbar = true;
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            isUserUpdatingTrackbar = false;

            if (wplayer.currentMedia != null)
            {
                wplayer.controls.currentPosition = trackBar1.Value;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            wplayer.settings.volume = trackBarVolume.Value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            trackBarVolume.Value = 0;
        }
    }
}
