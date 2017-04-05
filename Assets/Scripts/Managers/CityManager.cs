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

    public int cash;
    public int Cash
    {
        get { return cash; }
        set { cash = value; }
    }

    public int wood;
    public int Wood
    {
        get { return wood; }
        set { wood = value; }
    }

    public int wheat;
    public int Wheat
    {
        get { return wheat; }
        set { wheat = value; }
    }

    public int pops;
    public int Pops
    {
        get { return pops; }
        set { pops = value; }
    }
}
