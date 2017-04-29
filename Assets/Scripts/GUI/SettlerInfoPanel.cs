using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettlerInfoPanel : PanelBase
{
    public Settler Settler;
    public Text text1;

    public override void AssignContent<T>(T content)
    {
        this.Settler = content as Settler;
    }

    public override void Draw()
    {
        Clear();
        string entry = "";

        entry += Settler.FamilyName;
        entry += "\n" + Settler.tradeData.Name;

        text1.text = entry;
    }

    public override void Clear()
    {
        text1.text = "";
    }
}
