using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Main thing players will interact with directly and through it, with most other things
/// </summary>
public class Tile : MonoBehaviour {

    public bool IsBlocking; //Can't move through this: water, mountain etc
    public bool IsOccupied; //By building; blocks some types of movement

    public Building MyBuilding;
    public AreaData Area;
    public List<Settler> Settlers;

    public SpriteRenderer renderer2D;

    void Start()
    {
        //this.renderer2D = this.GetComponent<SpriteRenderer>();
        Render();
    }

    public void EnterSettler(Settler settler)
    {
        Settlers.Add(settler);
    }
    public void LeaveSettler(Settler settler)
    {
        Settlers.Remove(settler);
    }

    public void Render(bool alsoRenderBuilding = true)
    {
        renderer2D.sprite = Area.Sprite;
        if (alsoRenderBuilding && MyBuilding != null) MyBuilding.Render(); 
    }

    void OnMouseDown()
    {
        SelectTile();
    }

    public void SelectTile()
    {
        UIManager.Instance.UISelectTile(this);
    }


}
