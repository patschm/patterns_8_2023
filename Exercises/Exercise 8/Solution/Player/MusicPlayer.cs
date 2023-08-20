using System.Timers;

namespace Player;

public class MusicPlayer
{
    private State _state;
    private System.Timers.Timer _timer = new System.Timers.Timer();
    private TimeSpan _playTime = TimeSpan.Zero;

    public bool IsPlaying { get; set; } = false;
    public string? Title { get; set; } = "Some Music";
    public event EventHandler? Starting;
    public event EventHandler? Pausing;
    public event EventHandler? Stopping;
    public event EventHandler<ElapsedTimeArgs>? Elapsed;

    public MusicPlayer()
    {
        _state = new ReadyState(this);
        _timer.Interval = 1000; 
        _timer.Elapsed += Timer_Elapsed;
    }

    public void Start()
    {
        _state.Play();
    }
    public void Stop() 
    { 
        _state.Stop();
    }
    public void Pause()
    {
        _state.Pause();
    }
    public void FastForward()
    {
        _state.FastForward();
    }
    public void Rewind()
    {
        _state.Rewind();
    }

    internal void ChangeState(State state)
    {
        _state = state;
    }
    internal void PausePlaying()
    {
        // Pausing the song
        _timer.Stop();
        Pausing?.Invoke(this, EventArgs.Empty);
    }
    internal void StartPlaying()
    {
        // Playing the song
        _timer.Enabled = true;
        _timer.Start();
        Starting?.Invoke(this, EventArgs.Empty);
    }
    internal void StopPlaying()
    {
        // Stop playing the song
        _timer.Stop();
        _timer.Enabled = false;
        _playTime = TimeSpan.Zero;
        Stopping?.Invoke(this, EventArgs.Empty);
        Elapsed?.Invoke(this, new ElapsedTimeArgs { Time = _playTime });
    }
    internal void MoveForward()
    {
        // Fast Forward
        _playTime = _playTime.Add(TimeSpan.FromSeconds(10));
        Elapsed?.Invoke(this, new ElapsedTimeArgs { Time = _playTime });
    }
    internal void MoveBackward()
    {
        // Rewind
        _playTime = _playTime.Subtract(TimeSpan.FromSeconds(10));
        Elapsed?.Invoke(this, new ElapsedTimeArgs { Time = _playTime });
    }
    private void Timer_Elapsed(object? sender, ElapsedEventArgs e)
    {
        _playTime = _playTime.Add(TimeSpan.FromSeconds(1));
        Elapsed?.Invoke(this, new ElapsedTimeArgs { Time = _playTime});
    }
}