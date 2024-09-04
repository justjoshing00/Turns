using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager
{
    
    List<Player> players = new();

    public void CreatePlayers()
    {
        players = new() {new(), new(), new()};

        foreach (Player player in players)
        {
            player.GetUnitsFromManager();
        }
        

       

    }

    public List<Player> GetPlayers()
    {
        return players;
    }
}
