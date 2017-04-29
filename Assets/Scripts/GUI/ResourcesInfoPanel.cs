using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourcesInfoPanel : PanelBase
{
    public List<Resource> myRes;
    public Text Text1;
    public GameObject ListPanel;
    public GameObject ResourceButtonPrefab;

    public override void AssignContent<T>(T content)
    {
        myRes = content as List<Resource>;
    }

    public override void Clear()
    {
        var children = new List<GameObject>();
        foreach (Transform child in ListPanel.transform) children.Add(child.gameObject);
        children.ForEach(child => Destroy(child));
    }

    public override void Draw()
    {
        Clear();
        Text1.text = "Resources";

       for(int i = 0;i < myRes.Count; i++)
       {
            ResourceSelectionButton button = Instantiate(this.ResourceButtonPrefab).GetComponent<ResourceSelectionButton>();
            button.transform.SetParent(ListPanel.transform,false);
            button.SetResource(myRes[i]);

       }
    }
}
