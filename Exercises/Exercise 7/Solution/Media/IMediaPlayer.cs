namespace Media
{
    public interface IMediaPlayer
    {
        void Pause();
        void Play(string jwtToken, string user, string title);
        void Stop();
    }
}