using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Herkansing;

public class SongCollection
{
    string Title { get; set; }
    List <IPlayeble> Pleyebles { get; set; } = new List<IPlayeble>();



    public SongCollection(string tile) 
    {
        Title = tile;
    }

    public override string ToString()
    {
        return base.ToString();
    }

    public void ShowPlayebles( List <IPlayeble> playebles)
    {
        Pleyebles = playebles;
    }

}
