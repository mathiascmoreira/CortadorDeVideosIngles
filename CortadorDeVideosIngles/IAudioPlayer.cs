using System;

namespace CortadorDeVideosIngles
{
    public interface IAudioPlayer
    {
        PlayerStatus PlayerStatus { get; set; }
        MusicExecutionType MusicExecutionType { get; set; }

        void LoadMusic(string path);

        bool MusicLoaded { get; set; }

        void Play();
        void Pause();
        void Stop();
        void Restart();

        void IncreaseVolume();
        void DecreaseVolume();

        void IncreaseSpeed();
        void DecreaseSpeed();

        void SetSpeed(decimal speed);

        TimeSpan GetMusicTotalTime();
        TimeSpan GetMusicCurrentTime();

        void NextMusic();
        void PreviousMusic();

        void MarkPosition();
        void NextMarkedPosition(bool pause = false);
        void PreviousMarkedPosition(bool pause = false);
        void DeleteAllMarkedPositions();

        void StartSelection();
        void EndSelection();
        void NextSelection(bool pause = false);
        void PreviousSelection(bool pause = false);

        void SelectBetweenTwoMarkedPosition();
        void UnselectCurrentSelection();
        void UnSelectAllSelections();
        void DeleteCurrentSelection();
        void DeleteAllSelections();

        void SaveSelectionsAsSeparateFiles();
    }
}
