using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettlerListInfoPanel : PanelBase {

    List<Settler> settlers;
    public Text text1;
    public GameObject listPanel; // for instantiating buttons for settlers currently in the tile
    public GameObject SettleButtonPrefab;
   // public GameObject 

    public override void AssignContent<T>(T content)
    {
        this.settlers = content as List<Settler>;
    }

    public override void Clear()
    {
        var children = new List<GameObject>();
        foreach (Transform child in listPanel.transform) children.Add(child.gameObject);
        children.ForEach(child => Destroy(child));
    }

    public override void Draw()
    {
        Clear();
        string entry = "Units:";

        text1.text = entry;

        for(int i = 0;i < settlers.Count;i++)
        {
            SettlerSelectionButtonScript button = Instantiate(this.SettleButtonPrefab).GetComponent<SettlerSelectionButtonScript>();
            button.transform.SetParent(listPanel.transform,false);
            button.SetSettler(this.settlers[i]);
        }
    }




}
