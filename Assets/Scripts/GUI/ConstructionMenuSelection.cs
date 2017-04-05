using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// A specific construction option in the menu
/// </summary>
public class ConstructionMenuSelection : MonoBehaviour {

    public Text MyLabel;
    public Image MyImage;
    public Building MyBuilding;
    Toggle myToggle;


    void Start()
    {
        myToggle = GetComponent<Toggle>();
    }

    /// <summary>
    /// Properly sets up the image, text etc. of the toggle/button
    /// </summary>
    /// <param name="_build"></param>
    public void PrepareToggle(Building _build)
    {
        MyLabel.text = _build.BuildName;
        MyImage.sprite = _build.BuildSprite;
        MyBuilding = _build;
        
    }
    /// <summary>
    /// Makes sure the selection construction option get noticed by BuildingManager. Should probably be an event.
    /// </summary>
    public void ChangeSelection()
    {
        BuildingManager.Instance.BuildingSelectedForConstruction = MyBuilding;
        UIManager.Instance.ChangeMode(UIMode.Build);
    }

    
}
