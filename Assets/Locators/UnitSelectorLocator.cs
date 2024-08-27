using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSelectorLocator
{
    static UnitSelector unitSelector;

    public static void Register(UnitSelector manager)
    {
        unitSelector = manager;
    }
    public static UnitSelector GetManager()
    {
        return unitSelector;
    }
}
