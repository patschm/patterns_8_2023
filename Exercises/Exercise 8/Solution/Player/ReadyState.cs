namespace Player;

internal class ReadyState: State
{
    public ReadyState(MusicPlayer player): base (player)
    {
    }
    public override void Play()
    {
        _player.StartPlaying();
        _player.ChangeState(new PlayingState(_player));
    }
    public override void Stop()
    {
    }
    public override void Pause()
    {
    }
    public override void FastForward()
    {
    }
    public override void Rewind()
    {
    }
}
