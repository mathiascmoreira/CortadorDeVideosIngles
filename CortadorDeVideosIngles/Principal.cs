using System;
using System.Windows.Forms;
using System.Timers;

namespace CortadorDeVideosIngles
{
    public partial class Principal : Form
    {
        private readonly IAudioPlayer _audioPlayer;
        private System.Timers.Timer _timer;
        private bool stopSeek;

        public Principal()
        {
            InitializeComponent();

            _audioPlayer = new AudioPlayer();
            SeekerTrackBar.Maximum = 1000;

            _audioPlayer.OnPlayerEnds += _audioPlayer_OnPlayerEnds;

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
            Stop();
        }        

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            _audioPlayer.Restart();

            CheckTimer();

            SeekerTrackBar.Value = 0;
        }

        private void _audioPlayer_OnPlayerEnds(object sender, EventArgs e)
        {
            Stop();
        }

        private void Stop()
        {
            _audioPlayer.Stop();

            CheckTimer();

            SeekerTrackBar.Value = 0;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var playerPosition = _audioPlayer.GetPosition();

            var seekerBarPosition = Convert.ToInt32(decimal.Floor(_audioPlayer.GetPosition() * SeekerTrackBar.Maximum));

            if (SeekerTrackBar.InvokeRequired && !stopSeek)
            {
                SeekerTrackBar.BeginInvoke((MethodInvoker)delegate
                {
                    if (seekerBarPosition > SeekerTrackBar.Maximum)
                        Stop();
                    else
                        SeekerTrackBar.Value = seekerBarPosition;
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

        private void SeekerTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            var seekerBarPosition = Convert.ToDecimal(SeekerTrackBar.Value) / Convert.ToDecimal(SeekerTrackBar.Maximum);

            _audioPlayer.SetPosition(seekerBarPosition);

            stopSeek = false;
        }

        private void SeekerTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            stopSeek = true;
        }

        private void SeekerTrackBar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Left && e.KeyCode != Keys.Right)
                return;

            var seekerBarPosition = Convert.ToDecimal(SeekerTrackBar.Value) / Convert.ToDecimal(SeekerTrackBar.Maximum);

            _audioPlayer.SetPosition(seekerBarPosition);

            stopSeek = false;
        }

        private void SeekerTrackBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Left && e.KeyCode != Keys.Right)
                return;

            stopSeek = true;
        }
    }
}
