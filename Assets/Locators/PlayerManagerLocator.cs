using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManagerLocator
{

    static PlayerManager playerManager;

    public static void Register(PlayerManager manager)
    {
        playerManager = manager;
    }
    public static PlayerManager GetManager()
    {
        return playerManager;
    }
}
