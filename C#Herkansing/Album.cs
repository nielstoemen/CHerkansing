using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Herkansing;

public class Album : SongCollection
{

    List <Artist> Artists { get; set; } = new List<Artist>();

    public Album(List <Artist> artists, string name):base(name) 
    { 
        Artists = artists;
        name = name;
    }

    public void ShowArtist(List <Artist> artists)
    {
        Artists = artists;
    }

    public override string ToString()
    {
        return base.ToString();
    }

}
