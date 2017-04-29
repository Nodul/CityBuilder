using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileInfoPanel : PanelBase {

    public Text Text1;
    Tile Tile;

    public override void AssignContent<T>(T content)
    {
        this.Tile = content as Tile;
    }

    public override void Clear()
    {
        Text1.text = "";
    }

    public override void Draw()
    {
        string text = "";

        text += Tile.Area.Name + "\n";
        text += Tile.Area.Description;

        Text1.text = text;
    }
}
