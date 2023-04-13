public class Disc
{
    private string Album {get;set;}
    
    private string Artista{get; set;}

    private string[]Songs{get;set;}

    public int NumTracks =>Songs.Length;

    public string NombreCancion(int song)
    {
        return Songs[song];
    }

    public Disc(string album,string artista,string[] songs)
    {
        this.Album = album;
        this.Artista = artista;
        this.Songs = songs;
    }

    public override string ToString()
    {
        return $"Nombre del álbum : {Album} / Artista : {Artista}";
    }

}