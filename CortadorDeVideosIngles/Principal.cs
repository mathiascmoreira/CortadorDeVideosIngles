using System;
using System.Windows.Forms;
using System.Timers;

namespace CortadorDeVideosIngles
{
    public partial class Principal : Form
    {
        private readonly IAudioPlayer _audioPlayer;
        private System.Timers.Timer _timer;

        private int _playerPosition;

        public Principal()
        {
            InitializeComponent();

            _audioPlayer = new AudioPlayer();
            SeekerTrackBar.Maximum = 1000;

            SetTimer();
        }

        private void SetTimer()
        {
            _timer = new System.Timers.Timer
            {
                Interval = 300
            };

            _timer.Elapsed += Timer_Elapsed;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            _audioPlayer.Play();

            CheckTimer();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            _audioPlayer.Pause();

            CheckTimer();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            _audioPlayer.Stop();

            CheckTimer();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            _audioPlayer.Restart();

            CheckTimer();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _playerPosition = _audioPlayer.GetMusicCurrentTime().Milliseconds * 1000 /
                              _audioPlayer.GetMusicTotalTime().Milliseconds;

            if (SeekerTrackBar.InvokeRequired)
            {
                SeekerTrackBar.BeginInvoke((MethodInvoker)delegate
                {
                    SeekerTrackBar.Value = _playerPosition;
                });
            }

            if (timeLabel.InvokeRequired)
            {
                timeLabel.BeginInvoke((MethodInvoker)delegate
                {
                    timeLabel.Text = GetTimeLabelText();
                });
            }
        }

        private void StripMenuItemOpen_Click(object sender, EventArgs e)
        {
            var theDialog = new OpenFileDialog
            {
                Title = "Select a MP3 file",
                Filter = "MP3 files|*.mp3"
            };
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                _audioPlayer.LoadMusic(theDialog.FileName);

                Text = theDialog.FileName;
            }
        }

        public string GetTimeLabelText()
        {
            return $"{_audioPlayer.GetMusicCurrentTime().Minutes}:{_audioPlayer.GetMusicCurrentTime().Seconds}/" +
                $"{_audioPlayer.GetMusicTotalTime().Minutes}:{_audioPlayer.GetMusicTotalTime().Seconds}";
        }

        private void CheckTimer()
        {
            if (_audioPlayer.PlayerStatus == PlayerStatus.Playing)
                _timer.Start();
            else
                _timer.Stop();
        }
    }
}
