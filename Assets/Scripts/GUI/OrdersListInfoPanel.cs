using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrdersListInfoPanel : PanelBase
{
    public Text text1;
    public GameObject orderListPanel;

    public override void AssignContent<T>(T content)
    {
        throw new NotImplementedException();
    }

    public override void Draw()
    {
        text1.text = "Orders:";
    }
}
