using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Herkansing;

public class SuperUser : Person
{
    string Name { get; set; }

    public SuperUser(string name) : base(name)
    { 
        Name = name;
    }

    public void AddFriend (Person person)
    {

    }

    public void RemoveFriend (Person person) 
    { 
    
    }

    public void CreatePlaylist(string name) 
    {
    
    }

    public void RemovePlaylist(string name) 
    { 
    
    }

    public void AddToPlaylist(IPlayeble playeble) 
    { 
    
    }

    public void RemoveFromFromPlaylist(IPlayeble playeble) 
    { 
    
    }


}
