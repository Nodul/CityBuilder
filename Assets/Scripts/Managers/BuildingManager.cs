using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// [UNDER REVISION] Holds info and useful methods concerning all available buildings
/// </summary>
public class BuildingManager : MonoBehaviour
{
    private static BuildingManager _instance;
    public static BuildingManager Instance { get { return _instance; } }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

 

}
