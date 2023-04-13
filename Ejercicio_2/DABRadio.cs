public class DABRadio : IMedia
{
    const float SEEK_STEP = 0.5f;
    const float MAX_FREQUENCY = 108f;
    const float MIN_FRECUENCY = 87.5f;
    private float Frequency{get;set;}

    private MediaState State{get;set;}

    public DABRadio()
    {
        
    }

    public string MessageToDisplay 
    {
        get{
            switch(State)
            {
                case MediaState.Playing:
                                return $"HEARING... FM – {Frequency} MHz";
                case MediaState.Stopped:
                                return "RADIO OFF";
                case MediaState.Paused:
                                return $"PAUSED - BUFFERING...FM - {Frequency} MHz";
                default:
                        return "RADIO OFF";
                        
            }
        }
    }

    public void Play()
    { 
        this.State = MediaState.Playing;
        if(Frequency == 0) Frequency =  MIN_FRECUENCY;
    }

    public void Stop() => this.State = MediaState.Stopped;

    public void Pause() => this.State = MediaState.Paused;

    public void Next()
    {
        if((Frequency + SEEK_STEP) <= MAX_FREQUENCY ) Frequency += SEEK_STEP;
        else Frequency = MIN_FRECUENCY;
    }

    public void Previous()
    {
        if((Frequency - SEEK_STEP) >= MIN_FRECUENCY ) Frequency -= SEEK_STEP;
        else Frequency = MAX_FREQUENCY;
    }
}