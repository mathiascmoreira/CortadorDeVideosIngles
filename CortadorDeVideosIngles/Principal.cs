using NAudio.Wave;
using System;
using System.Windows.Forms;
using System.Timers;

namespace CortadorDeVideosIngles
{
    public partial class Principal : Form
    {
        private IWavePlayer waveOutDevice;
        private AudioFileReader audioFileReader;
        private System.Timers.Timer timer;

        int _playerPosition;

        public Principal()
        {
            InitializeComponent();

            waveOutDevice = new WaveOut();

            timer = new System.Timers.Timer();
            timer.Interval = 300;
            timer.Elapsed += Timer_Elapsed;
           
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (audioFileReader != null)
            {
                waveOutDevice.Play();

                timer.Start();
            }
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _playerPosition = Convert.ToInt32(decimal.Round(audioFileReader.Position * 1000 / audioFileReader.Length));

            if (trackBar.InvokeRequired)
            {
                trackBar.BeginInvoke((MethodInvoker)delegate
                {
                    trackBar.Value = _playerPosition;
                });
            }

            if (timeLabel.InvokeRequired)
            {
                timeLabel.BeginInvoke((MethodInvoker)delegate
                {
                    timeLabel.Text = $" {audioFileReader.CurrentTime.Minutes}:{audioFileReader.CurrentTime.Seconds}/{audioFileReader.TotalTime.Minutes}:{audioFileReader.TotalTime.Seconds}";
                });
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            waveOutDevice.Pause();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            waveOutDevice.Stop();
            timer.Stop();

            trackBar.Value = 0;
            audioFileReader.Position = 0;
        }

        private void stripMenuItemOpen_Click(object sender, EventArgs e)
        {
            var theDialog = new OpenFileDialog
            {
                Title = "Select a MP3 file",
                Filter = "MP3 files|*.mp3"
            };
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                audioFileReader = new AudioFileReader(theDialog.FileName);
                waveOutDevice.Init(audioFileReader);

                audioFileReader.Position = 0;

                Text = theDialog.FileName;
            }
        }
    }
}
