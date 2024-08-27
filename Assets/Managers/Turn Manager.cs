using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager
{
    
    public Player CurrentPlayer;

    int index = 0;
    List<Player> players;

    public void init()
    {

        players = PlayerManagerLocator.GetManager().GetPlayers();
        CurrentPlayer = players[0];
    }


    void NextTurn()
    {
        index += 1;
        CurrentPlayer = players[index];
    }

    void SetTurn(Player player)
    {
        CurrentPlayer = player;
    }

    Player GetTurn()
    {
        return CurrentPlayer;
    }
}
