using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UIMode
{
    Default,
    Build
}

public class UIManager : MonoBehaviour {

    private static UIManager _instance;
    public static UIManager Instance { get { return _instance; } }

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

    private void Start()
    {
        if(Selector == null)
        {
            Selector = GameObject.FindGameObjectWithTag("Selector").GetComponent<Selector>();
         
        }
        Selector.enabled = false; // turn off so it won't show without having selected something.
    }

    public UIMode uiMode;
    public UIMode UIMode
    {
        get { return uiMode; }
    }

    public Tile SelectedTile;
    public Settler SelectedSettler;
    public Selector Selector;

    public TileInfoPanel tileIP;
    public BuildingInfoPanel buildingIP;

    public SettlerListInfoPanel settlerListIP;
    public SettlerInfoPanel settlerIP;

    public void UISelectTile(Tile tile)
    {
        SelectedTile = tile;
        Selector.transform.position = tile.transform.position;
        Selector.enabled = true;

        tileIP.gameObject.SetActive(true);
        tileIP.AssignContent(tile);
        tileIP.Draw();

        buildingIP.gameObject.SetActive(true);
        buildingIP.AssignContent(tile.MyBuilding);
        buildingIP.Draw();

        settlerListIP.gameObject.SetActive(true);
        settlerListIP.AssignContent(tile.Settlers);
        settlerListIP.Draw();
    }

    public void UIDeselectTile()
    {
        SelectedTile = null;
        Selector.enabled = false;

        tileIP.gameObject.SetActive(false);
        buildingIP.gameObject.SetActive(false);

        settlerListIP.gameObject.SetActive(false);
        settlerIP.gameObject.SetActive(false);


    }

    public void UISelectSettler(Settler settler)
    {
        this.SelectedSettler = settler;
        settlerIP.gameObject.SetActive(true);
        settlerIP.AssignContent(settler);
        settlerIP.Draw();
    }
    public void UIDeselectSettler()
    {
        this.SelectedSettler = null;
        settlerIP.gameObject.SetActive(false);
        settlerIP.Clear();
    }

}
