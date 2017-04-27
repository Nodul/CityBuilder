using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Trade, as in occupation, vocation
/// </summary>
public class TradeData : ScriptableObject {

    public string Name;
    public Sprite Sprite;

    // A dictionary, <Skills,int> would be best probably, instead of a List
    // public List<string> Skills;
}
