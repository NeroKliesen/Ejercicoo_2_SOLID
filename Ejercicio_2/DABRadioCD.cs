public class DABRadioCD : IMedia
{
    public IMedia ActiveDevice {get;set;}
    public Disc InsertCD
        {
            set
            {
                cd.InsertMedia(value);

                ActiveDevice = cd;
                Play();
            }
        }

    public CDPlayer cd;

    public DABRadio radio;

    public DABRadioCD()
    {
        this.radio  = new DABRadio();
        this.cd = new CDPlayer();
        ActiveDevice= this.radio;
    }

    public void ExtractCD()
    {
        cd.ExtractMedia();
    }

    public string MessageToDisplay
    {
        get{ switch(ActiveDevice )
            {
                case CDPlayer:  
                            return "CD PLAYER ON" +
                            "\n[1]Play\n[2]Pause\n[3]Stop\n[4]Prev\n[5]Next\n[6]Switch\n[7]Insert CD\n[8]Extract CD\n[ESC]Turn off";
                case DABRadio:
                            return "RADIO ON\n " +
                            "[1]Play\n[2]Pause\n[3]Stop\n[4]Prev\n[5]Next\n[6]Switch\n[7]Insert CD\n[8]Extract CD\n[ESC]Turn off";
                
                default: 
                        return "DIVICE OFF";
            }
        }
    } 

    public void SwitchMode()
    {
        if(ActiveDevice is CDPlayer) ActiveDevice = radio;
        else if(ActiveDevice is DABRadio) ActiveDevice = cd;
    }

    public void Play() => ActiveDevice.Play();

    public void Stop() => ActiveDevice.Stop();

    public void Pause() => ActiveDevice.Pause();

    public void Next() => ActiveDevice.Next();

    public void Previous() => ActiveDevice.Previous();


}