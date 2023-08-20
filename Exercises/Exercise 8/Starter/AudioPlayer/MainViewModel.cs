using CommunityToolkit.Mvvm.Input;
using Player;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace AudioPlayer;

public class MainViewModel : INotifyPropertyChanged
{
    private TimeSpan _elapsed = TimeSpan.Zero;
    private string? _song = "";
    private MusicPlayer _player = new MusicPlayer();
    private bool _rewindEnabled = false;
    private bool _fastForwardEnabled = false;
    private bool _stopEnabled = false;
    private bool _pauseEnabled = false;
    private bool _playEnabled = true;

    public bool PlayEnabled
    {
        get { return _playEnabled; }
        set
        {
            _playEnabled = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PlayEnabled)));
        }
    }
    public bool PauseEnabled
    {
        get { return _pauseEnabled; }
        set
        {
            _pauseEnabled = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PauseEnabled)));
        }
    }
    public bool StopEnabled
    {
        get { return _stopEnabled; }
        set
        {
            _stopEnabled = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StopEnabled)));
        }
    }
    public bool FastForwardEnabled
    {
        get { return _fastForwardEnabled; }
        set 
        { 
            _fastForwardEnabled = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FastForwardEnabled)));
        }
    }
    public bool RewindEnabled
    {
        get { return _rewindEnabled; }
        set 
        { 
            _rewindEnabled = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RewindEnabled)));
        }
    }


    public event PropertyChangedEventHandler? PropertyChanged;
    public TimeSpan Elapsed 
    { 
        get { return _elapsed; } 
        set 
        { 
            _elapsed = value; 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Elapsed)));   
        }
    }
    public string? Song 
    { 
        get { return _song; }
        set
        {
            _song = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Song))); 
        }
    }

    public ICommand PlayCommand { get; }
    public ICommand PauseCommand { get; }
    public ICommand StopCommand { get; }
    public ICommand FastForwardCommand { get; }
    public ICommand RewindCommand { get; }

    public MainViewModel()
    {
        PlayCommand = new RelayCommand(Play);
        PauseCommand = new RelayCommand(Pause);
        StopCommand = new RelayCommand(Stop);
        FastForwardCommand = new RelayCommand(FastForward);
        RewindCommand = new RelayCommand(Rewind);
        _player.Elapsed += Player_Elapsed;
        Song = _player.Title;
    }

    private void Player_Elapsed(object? sender, ElapsedTimeArgs e)
    {
        Elapsed = e.Time;
    }

    private void Rewind()
    {
        _player.Rewind();
    }
    private void FastForward()
    {
        _player.FastForward();
    }
    private void Stop()
    {
        _player.Stop();
        PauseEnabled = false;
        FastForwardEnabled = false;
        RewindEnabled = false;
        StopEnabled = false;
    }
    private void Pause()
    {
        _player.Pause();
        PauseEnabled = true;
        FastForwardEnabled = false;
        RewindEnabled = false;
        StopEnabled = true;
    }
    private void Play()
    {
        _player.Start();
        PauseEnabled = true;
        FastForwardEnabled = true;
        RewindEnabled = true;
        StopEnabled = true;
    }
}
