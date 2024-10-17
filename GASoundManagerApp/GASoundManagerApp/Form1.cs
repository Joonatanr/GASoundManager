using System.Media;

namespace GASoundManagerApp
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            wplayer.URL = "audio_clips/Test/MountainKing_edited2.mp3";
            wplayer.controls.play();
        }
    }
}
