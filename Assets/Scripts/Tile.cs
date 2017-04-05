using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

    public bool IsBlocking; //Can't move through this: water, mountain etc
    public bool IsOccupied; //By building; blocks some types of movement

    public Building MyBuilding;

    public void AssignBuilding(Building newBuilding)
    {
        MyBuilding = newBuilding;
        MyBuilding.MyTile = this;
        IsOccupied = true;
    }
    public void UnassignBuilding()
    {
        MyBuilding.MyTile = null;
        DestroyObject(MyBuilding.gameObject);
        MyBuilding = null;
        IsOccupied= false;
    }

    void OnMouseDown()
    {
        //AttempConstruction();
    }

    /// <summary>
    /// [Deprecated] 
    /// </summary>
    void AttempConstruction()
    {
        
        if(UIManager.Instance.UIMode == UIMode.Build)
        {
            if (IsBlocking == false && IsOccupied == false)
            {
                Building NewBuilding = BuildingManager.Instance.ConstructBuilding(this);
                AssignBuilding(NewBuilding);
            }
            else
            {
                Debug.Log("Cannot construct building, this tile is already occupied!");
            }
        }
      
    }
}
