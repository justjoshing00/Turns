using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSelector
{

    int index = 0;
    Unit CurrentUnit;

    public void init()
    {
        SetUnit(new Unit("bleh"));
    }
    public void NextUnit()
    {
        //TODO wraparaound
        if (index >= TurnManagerLocator.GetManager().CurrentPlayer.Units.Count - 1)
        {
            return;
        }
        index += 1;
        CurrentUnit = TurnManagerLocator.GetManager().CurrentPlayer.Units[index];




    }

    public void SetUnit(Unit unit)
    {
        CurrentUnit = unit;
    }

    public Unit GetCurrentUnit()
    {
        return CurrentUnit;
    }
}
