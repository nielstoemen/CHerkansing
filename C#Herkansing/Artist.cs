using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Herkansing;

public class Artist
{
    string Name { get; set; }
    public List<Album> Albums { get; set; } = new List<Album>();
    public List<song> Songs { get; set; } = new List<song>();



    public Artist (string name, List<Album> albums)
    {
        name = Name;
        Albums = albums;
    }

    public void AddSong()
    {
        
    }

    public void AddAlbum()
    {

    }

    public override string ToString()
    {
        return base.ToString();
    }



}
