using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager
{
    Player player1;
    Player player2;
    Player Neutral;

    List<Player> players = new();

    public void CreatePlayers()
    {
        player1 = new();
        player2 = new();
        Neutral = new();

        players.Add(player1);
        players.Add(player2);
        players.Add(Neutral);

        players[0].GetUnitsFromManager();
        players[1].GetUnitsFromManager();
        players[2].GetUnitsFromManager();

    }

    public List<Player> GetPlayers()
    {
        return players;
    }
}
