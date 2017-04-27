using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Buildings are intrisincly tied to Tile, they cannot exist without it basically
/// </summary>
public class Building : MonoBehaviour {

    public Tile MyTile; //Don't know if i'll need this, I'll keep it just in case
    public BuildingData BuildingData;

    public SpriteRenderer sprRen;

    void Start()
    {
        //sprRen = GetComponentInChildren<SpriteRenderer>();
        Render();
    }

    public void Render()
    {
        this.sprRen.sprite = BuildingData.Sprite; //Just in case I click wrong in the Editor while preparing the prefab
        
    }
}
