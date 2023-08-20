namespace Player;

internal abstract class State
{
    protected readonly MusicPlayer _player;

    public State(MusicPlayer player)
    {
        _player = player;
    }
    public abstract void Play();
    public abstract void Stop();
    public abstract void Pause();
    public abstract void FastForward();
    public abstract void Rewind();
}
