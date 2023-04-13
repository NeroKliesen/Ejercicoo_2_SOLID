public interface IMedia
{
    public string MessageToDisplay{get;}
    void Play();
    void Stop();
    void Pause();
    void Next();
    void Previous();
}