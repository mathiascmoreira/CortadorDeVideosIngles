using System;
using System.IO;
using NAudio.Wave;

namespace CortadorDeVideosIngles
{
    public class AudioPlayer : IAudioPlayer
    {
        private IWavePlayer wavePlayer;
        private AudioFileReader audioFileReader;

        public MusicExecutionType MusicExecutionType { get; set; }

        public bool MusicLoaded { get; set; }

        public AudioPlayer()
        {
            wavePlayer = new WaveOut();
        }

        public PlayerStatus PlayerStatus { get; set; }

        public void LoadMusic(string path)
        {
            if (!File.Exists(path))
                throw new Exception("Arquivo não existe!");

            var fileInfo = new FileInfo(path);

            if(!fileInfo.Extension.ToUpper().Equals(".MP3"))
                throw new Exception("Arquivo deve ser mp3!");


            audioFileReader = new AudioFileReader(path);

            MusicLoaded = true;

            wavePlayer.Init(audioFileReader);
        }

        public void Play()
        {
            if (!MusicLoaded)
                return;

            wavePlayer.Play();

            PlayerStatus = PlayerStatus.Playing;
        }

        public void Pause()
        {
            if (!MusicLoaded)
                return;

            wavePlayer.Pause();

            PlayerStatus = PlayerStatus.Paused;
        }

        public void Restart()
        {
            if (!MusicLoaded)
                return;

            wavePlayer.Stop();
            wavePlayer.Play();

            PlayerStatus = PlayerStatus.Playing;
        }

        public void Stop()
        {
            if (!MusicLoaded)
                return;

            wavePlayer.Stop();

            PlayerStatus = PlayerStatus.Stopped;
        }

        public TimeSpan GetMusicTotalTime()
        {
            return audioFileReader?.TotalTime ?? TimeSpan.Zero;
        }

        public TimeSpan GetMusicCurrentTime()
        {
            return audioFileReader?.CurrentTime ?? TimeSpan.Zero;
        }

        public void DecreaseSpeed()
        {
            throw new NotImplementedException();
        }

        public void DecreaseVolume()
        {
            throw new NotImplementedException();
        }

        public void DeleteAllMarkedPositions()
        {
            throw new NotImplementedException();
        }

        public void DeleteAllSelections()
        {
            throw new NotImplementedException();
        }

        public void DeleteCurrentSelection()
        {
            throw new NotImplementedException();
        }

        public void EndSelection()
        {
            throw new NotImplementedException();
        }

        public void IncreaseSpeed()
        {
            throw new NotImplementedException();
        }

        public void IncreaseVolume()
        {
            throw new NotImplementedException();
        }

        public void MarkPosition()
        {
            throw new NotImplementedException();
        }

        public void NextMarkedPosition(bool pause = false)
        {
            throw new NotImplementedException();
        }

        public void NextMusic()
        {
            throw new NotImplementedException();
        }

        public void NextSelection(bool pause = false)
        {
            throw new NotImplementedException();
        }

        public void PreviousMarkedPosition(bool pause = false)
        {
            throw new NotImplementedException();
        }

        public void PreviousMusic()
        {
            throw new NotImplementedException();
        }

        public void PreviousSelection(bool pause = false)
        {
            throw new NotImplementedException();
        }

        public void SaveSelectionsAsSeparateFiles()
        {
            throw new NotImplementedException();
        }

        public void SelectBetweenTwoMarkedPosition()
        {
            throw new NotImplementedException();
        }

        public void SetSpeed(decimal speed)
        {
            throw new NotImplementedException();
        }

        public void StartSelection()
        {
            throw new NotImplementedException();
        }

        public void UnSelectAllSelections()
        {
            throw new NotImplementedException();
        }

        public void UnselectCurrentSelection()
        {
            throw new NotImplementedException();
        }
    }
}
