using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The menu which allows to select building for construction
/// </summary>
public class BuildingConstructionMenu : MonoBehaviour {

    public GameObject ConstructionMenu;
    public GameObject ConstructionMenuSelectionPrefab;
    public ToggleGroup myTG; //if this isn't public, then GetComponent<ToggleGroup>() doesn't work :/

    private bool MenuPopulated = false;
    
    void Awake()
    {
        myTG = this.GetComponent<ToggleGroup>();
    }

    void Start()
    {
        if (ConstructionMenu == null) ConstructionMenu = GameObject.FindGameObjectWithTag("ConstructionSelectionMenu");
        if (MenuPopulated == false) 
        {
            PopulateConstructionMenu();
            MenuPopulated = true;
        }

    }
    /// <summary>
    /// Creates a list of all buildings available for construction in this scenario. Needs to be run only once, the first time this menu is shown.
    /// </summary>
    public void PopulateConstructionMenu()
    {
        List<GameObject> _buildings = BuildingManager.Instance.BuildingsList;
        for(int i = 0; i < _buildings.Count; i++)
        {
            GameObject _option = Instantiate(ConstructionMenuSelectionPrefab);
            _option.transform.SetParent(this.transform, false);
            _option.GetComponent<Toggle>().group = myTG;
            myTG.RegisterToggle(_option.GetComponent<Toggle>());
            _option.GetComponent<ConstructionMenuSelection>().PrepareToggle(_buildings[i].GetComponent<Building>());
        }
        
    }
    

}
