using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour {

    public Tile MyTile; //Don't know if i'll need this, I'll keep it just in case

    public string BuildName;
    public Sprite BuildSprite;
    SpriteRenderer sprRen;

    public int CashBuild;
    public int WoodBuild;

    void Start()
    {
        sprRen = GetComponent<SpriteRenderer>();
        sprRen.sprite = BuildSprite; //Just in case I click wrong in the Editor while preparing the prefab
    }
}
