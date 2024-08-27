using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    Setup setup;
    // Start is called before the first frame update
    void Start()
    {
        setup = new();
        setup.SetupSystems();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {

            UnitSelectorLocator.GetManager().NextUnit();
            Debug.Log(UnitSelectorLocator.GetManager().GetCurrentUnit().name);
           
        }

    }
}
