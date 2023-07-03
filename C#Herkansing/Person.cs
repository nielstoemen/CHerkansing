using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Herkansing;

public class Person
{
    string Name { get; set; }
    List<Person> Friends { get; set; } = new List<Person>();
    List<Playlist> Playlists { get; set; } = new List<Playlist>();

    public Person (string name)
    {
        Name = name;
    }

    public void ShowFriends()
    {

    }

    public void ShowPlaylists() 
    { 
    
    }

    public void SelectPlaylist()
    {
        foreach (Playlist playlist in Playlists) 
        { 
            Console.WriteLine(nameof(playlist));
        }
    }

    public override string ToString()
    {
        return base.ToString();
    }



}
