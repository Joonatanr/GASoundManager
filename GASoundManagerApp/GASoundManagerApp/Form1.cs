using System.IO;
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

#if false
            /* Set up some test buttons as a placeholder for testing */

            List<string> testAudioFiles = new List<string>();

            testAudioFiles.Add("audio_clips/folder 2/MountainKing_edited2.mp3");
            testAudioFiles.Add("audio_clips/folder 1/MorningMood_edited.mp3");

            userControlAudioButtonList1.AudioFiles = testAudioFiles;
            userControlAudioButtonList1.AudioFilePlayed = new UserControlAudioButtonList.AudioFilePlayedHandler(playAudio);
#endif

            /* 1. Lets get a list of directories here first... */
            string [] dirs = Directory.GetDirectories("audio_clips");
            tabControl1.TabPages.Clear();

            foreach (string dir in dirs)
            {
                try
                {
                    //string DirectoryName = Path.GetFileName(Path.GetDirectoryName(dir));
                    FileInfo fi = new FileInfo(dir);
                    //Console.WriteLine(fi.Name);
                    string DirectoryName = fi.Name;
                    DebugPrint("Found directory : " + DirectoryName);

                    /* Now lets create a tab for each of these directories... */
                    TabPage myTabPage = new TabPage(DirectoryName);

                    /* Set up an AudioButtonList control */
                    /* First lets get all the files in the folders. */
                    string[] fileArray = Directory.GetFiles(dir);

                    foreach (string file in fileArray)
                    {
                        DebugPrint("Found file " + file.ToString());
                    }

                    /* Now lets create a control for these files. */
                    UserControlAudioButtonList myNewButtonList = new UserControlAudioButtonList();
                    myNewButtonList.AudioFiles = fileArray.ToList();
                    myNewButtonList.AudioFilePlayed = new UserControlAudioButtonList.AudioFilePlayedHandler(playAudio);

                    myNewButtonList.Size = new Size(myTabPage.Size.Width - 5, myTabPage.Size.Height - 5);
                    myNewButtonList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

                    myTabPage.Controls.Add(myNewButtonList);

                    tabControl1.TabPages.Add(myTabPage);
                }
                catch(Exception ex)
                {
                    /* TODO : Report error!!! */
                }
            }
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


        private void DebugPrint(string str)
        {
            richTextBoxDebug.AppendText(str + Environment.NewLine);
        }
    }
}
