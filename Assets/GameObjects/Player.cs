using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public List<Unit> Units;
    

    public void GetUnitsFromManager()
    {
        
        Units = UnitManagerLocator.GetManager().GetUnits(); 
    }

    List<Unit> GetUnitsUnderPlayerControl()
    {
        return Units;
    }
}
