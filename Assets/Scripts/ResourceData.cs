using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ResourceCategory
{
    Food,Drink,Wood,Stone, Clothing
}

public class ResourceData : ScriptableObject {

    public string Name;
    public Sprite Sprite;
    public ResourceCategory ResourceCategory;
    public int StartingValue;
}
