using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManagerLocator
{
    static UnitManager unitManager;
    
    public static void Register(UnitManager manager)
    {
        unitManager = manager;
    }
    public static UnitManager GetManager()
    {
        return unitManager;
    }
}
