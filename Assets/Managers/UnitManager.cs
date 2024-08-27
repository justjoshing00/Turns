using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager 
{
    //these should come from the level data, but its fine for now
    Unit mech;
    Unit soldier;
    Unit drone;

    List<Unit> units = new();

    public void CreateUnits()
    {
        mech = new("mech");
        soldier = new("soldier");
        drone = new("drone");

        units.Add(mech);
        units.Add(soldier);
        units.Add(drone);

    }

    public List<Unit> GetUnits()
    {
        return units;
    }
}
