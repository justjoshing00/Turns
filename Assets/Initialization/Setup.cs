using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setup
{
    // all managers and systems setup and initialize here
    TurnManager turnManager;
    UnitManager unitManager;
    PlayerManager playerManager;
    UnitSelector unitSelector;




    public void SetupSystems()
    {
        turnManager = new();
        unitManager = new();
        playerManager = new();
        unitSelector = new();

        UnitManagerLocator.Register(unitManager);
        TurnManagerLocator.Register(turnManager);
        PlayerManagerLocator.Register(playerManager);
        UnitSelectorLocator.Register(unitSelector);

        UnitManagerLocator.GetManager().CreateUnits();
        PlayerManagerLocator.GetManager().CreatePlayers();

        TurnManagerLocator.GetManager().init();
        UnitSelectorLocator.GetManager().init();
        
    }


}
