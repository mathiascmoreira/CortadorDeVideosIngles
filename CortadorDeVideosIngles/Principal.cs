using NAudio.Wave;
using System;
using System.Windows.Forms;
using System.Timers;

namespace CortadorDeVideosIngles
{
    public partial class Principal : Form
    {
        IWavePlayer waveOutDevice;
        AudioFileReader audioFileReader;

        long audioPosition = 0;
        int playerPosition = 0;

        public Principal()
        {
            InitializeComponent();

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            waveOutDevice = new WaveOut();
            audioFileReader = new AudioFileReader("C:\\Users\\Mathias\\Videos\\4K Video Downloader\\Does Drinking Alcohol Kill Your Gut Bacteria.mp3");
            waveOutDevice.Init(audioFileReader);

            waveOutDevice.Play();

            var timer = new System.Timers.Timer();
            timer.Interval = 300;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            playerPosition = Convert.ToInt32(decimal.Round(((audioFileReader.Position * 1000) / audioFileReader.Length)));

            if (trackBar.InvokeRequired)
            {
                trackBar.BeginInvoke((MethodInvoker)delegate
                {
                    trackBar.Value = playerPosition;
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
        }
    }
}
