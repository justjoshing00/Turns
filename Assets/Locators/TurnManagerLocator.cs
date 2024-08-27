using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManagerLocator
{
    static TurnManager turnManager;

    public static void Register(TurnManager manager)
    {
        turnManager = manager;
    }
    public static TurnManager GetManager()
    {
        return turnManager;
    }
}
