using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Resources
{
    Cash,Wood,Wheat,Pops
}

public class CityManager : MonoBehaviour
{

    private static CityManager _instance;
    public static CityManager Instance { get { return _instance; } }

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
