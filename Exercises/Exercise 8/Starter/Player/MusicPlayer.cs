using System.Timers;

namespace Player;

public class MusicPlayer
{
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
        _timer.Interval = 1000; 
        _timer.Elapsed += Timer_Elapsed;
    }

    public void Pause()
    {
        // Pausing the song
        if (!IsPlaying) return;
        _timer.Stop();
        Pausing?.Invoke(this, EventArgs.Empty);
    }
    public void Start()
    {
        // Playing the song
        _timer.Enabled = true;
        _timer.Start();
        IsPlaying = true;
        Starting?.Invoke(this, EventArgs.Empty);
    }
    public void Stop()
    {
        // Stop playing the song
        _timer.Stop();
        _timer.Enabled = false;
        _playTime = TimeSpan.Zero;
        IsPlaying = false;
        Stopping?.Invoke(this, EventArgs.Empty);
        Elapsed?.Invoke(this, new ElapsedTimeArgs { Time = _playTime });
    }
    public void FastForward()
    {
        // Fast Forward
        if (!IsPlaying) return;
        _playTime = _playTime.Add(TimeSpan.FromSeconds(10));
        Elapsed?.Invoke(this, new ElapsedTimeArgs { Time = _playTime });
    }
    public void Rewind()
    {
        // Rewind
        if (!IsPlaying) return;
        _playTime = _playTime.Subtract(TimeSpan.FromSeconds(10));
        Elapsed?.Invoke(this, new ElapsedTimeArgs { Time = _playTime });
    }
    private void Timer_Elapsed(object? sender, ElapsedEventArgs e)
    {
        _playTime = _playTime.Add(TimeSpan.FromSeconds(1));
        Elapsed?.Invoke(this, new ElapsedTimeArgs { Time = _playTime});
    }
}