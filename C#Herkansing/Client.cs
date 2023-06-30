using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C_Herkansing;

public class Client
{
    string idk { get; set; }
    int CurrentTime { get; set; }
    bool Playing { get; set; }
    bool Shuffle { get; set; }
    bool Repeat { get; set; }
    string ActiveUser { get; set; } //idk
    List <Album> AllAlbums { get; set; } = new List<Album>();
    List <song> AllSongs { get; set; } = new List<song>();
    List <Person> AllUsers { get; set; } = new List<Person>();


    
    //voids----------------------

    public Client (List<Person> persons, List <Album> albums, List <song> songs)
    {
        AllAlbums = albums;
        AllSongs = songs;
        AllUsers = persons;
    }


    public void SetActiveUser(Person activeUser)
    {

    }

    //selecteerd alle albums en print ze uit
    public void ShowAllAlbums()
    {
        foreach(Album album in AllAlbums) 
        {
            Console.WriteLine(album.ToString);
        }
    }
    
    //selecteerd het eerste album in de List
    public void SelectAlbum(int index)
    {
        var firstInt = AllAlbums.ElementAt(index);
        Console.WriteLine(firstInt.ToString());
    }

    public void ShowAllSongs()
    {
        foreach(song song in AllSongs)
        {
            Console.WriteLine(song.ToString);
        }
    }

    public void SelectSongs(int index)
    {
        var firstInt = AllSongs.ElementAt(index);
        Console.WriteLine(firstInt.ToString());
    }

    public void ShowAllUsers() 
    { 
        foreach(Person person in AllUsers)
        {
            Console.WriteLine(person.ToString());
        }
    }

    public void SelectUser(int index)
    {
        var firstInt = AllUsers.ElementAt(index);
        Console.WriteLine(firstInt.ToString());
    }

    public void ShowUserPlaylist(List <Playlist> playlists)
    { 
        foreach (Playlist playlist in playlists)
        {
            Console.WriteLine(playlist.ToString());
        }
    }

    public void SelectUserPlaylist(int index, List<song> allsongs)
    {
        var firstInt = allsongs.ElementAt(index);
        Console.WriteLine(firstInt.ToString());
    }

    //commands---------------

    public void Play()
    {
        Console.WriteLine("Playing song");
    }

    public void Pause()
    {
        Console.WriteLine("Paused song");
    }
    public void Stop()
    {
        Console.WriteLine("stoppped playing");
    }

    public void NextSong()
    {
        Console.WriteLine("Playing next song");
    }

    public void SetNextShuffle()
    {
        if (Shuffle == true)
        {
            Shuffle = false;
        }
        else
        {
            Shuffle = true;
        }
    }

    public void SetRepeat()
    {
        if (Repeat == true)
        {
            Repeat = false;
        }else
        {
            Repeat = true;
        }
    }

    //playlist commands---------------

    public void CreatePlaylist()
    {

    }

    public void ShowPlaylist()
    {

    }

    public void SelectPlaylist()
    {

    }

    public void RemovePlaylist()
    {

    }

    public void AddToPlaylist()
    {

    }

    public void ShowSongInPlaylist()
    {

    }

    public void RemoveFromPlaylist()
    {

    }

    //friend commands----------------

    public void ShowFriends()
    {

    }

    public void SelectFriend()
    {

    }

    public void AddFriend()
    {

    }

    public void RemoveFriend()
    {

    }



}
