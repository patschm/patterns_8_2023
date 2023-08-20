namespace Player;

internal class PauseState : State
{
    public PauseState(MusicPlayer player): base (player)
    {
    }
    public override void Play()
    {
        _player.StartPlaying();
        _player.ChangeState(new PlayingState(_player));
    }
    public override void Stop()
    {
        _player.StopPlaying();
        _player.ChangeState(new ReadyState(_player));
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
