using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Herkansing;

public class song
{
    string Title { get; set; }
    List <Artist> Artists { get; set; } = new List<Artist>();
    string Genre { get; set; }
    int Duur { get; set; }

    public  song (string title, List <Artist> artists, int duur, string genre)
    {
        Title = title;
        Artists = artists;
        Genre = genre;
        Duur = duur;
    }

    public override string ToString()
    {
        return base.ToString();
    }

    public void Play()
    {
        Console.WriteLine("number is being played");
    }

    public void Pause()
    {
        Console.WriteLine("number has been paused");
    }

    public void Stop()
    {
        Console.WriteLine("number has been stopped");
    }

    public void Next()
    {
        Console.WriteLine("next number is being played");
    }



}
