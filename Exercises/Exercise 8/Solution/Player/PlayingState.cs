namespace Player;

internal class PlayingState : State
{
    public PlayingState(MusicPlayer player): base (player)
    {
    }
    public override void Play()
    {

    }
    public override void Stop()
    {
        _player.StopPlaying();
        _player.ChangeState(new ReadyState(_player));
    }
    public override void Pause()
    {
        _player.PausePlaying();
        _player.ChangeState(new PauseState(_player));   
    }
    public override void FastForward()
    {
        _player.MoveForward();
    }
    public override void Rewind()
    {
        _player.MoveBackward();
    }
}
