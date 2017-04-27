using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingInfoPanel : PanelBase {


    public Text Text1;
    public Building Building;

    public override void AssignContent<T>(T content)
    {
        this.Building = content as Building;
    }

    public override void Draw()
    {
        string text = "";

        text += Building.BuildingData.Name + "\n";
        text += Building.BuildingData.Description;

        Text1.text = text;
    }
}
