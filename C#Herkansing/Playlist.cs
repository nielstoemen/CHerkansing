using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Herkansing;

public class Playlist
{
    string Owner { get; set; }

    public Playlist(Person person, string owner) 
    {
        Owner = owner;
    }

    public void Add(IPlayeble playeble)
    {

    }

    public void Remove(IPlayeble playeble) 
    { 
    
    }

    public override string ToString()
    {
        return base.ToString();
    }

}
