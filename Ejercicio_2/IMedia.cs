public interface IMedia : IMessageToDisplay
{
    public string MessageToDisplay{get;}
    string Name { get; }
    
    void Play();
    void Stop();
    void Pause();
    void Next();
    void Previous();
}