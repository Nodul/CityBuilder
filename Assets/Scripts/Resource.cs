using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Basically a wrapper class for the ResourceData objects
/// </summary>
[System.Serializable]
public class Resource {

    public string Name; // this one allows to auto change elements labels
    public ResourceData ResourceData;
    public int Amount;
    // or just make it a Dictionary<Resource,int> in CityManager?

}
