using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settler : MonoBehaviour
{
    SpriteRenderer renderer2D;

    public string FirstName; // used mostly by nobles and dignitaries
    public string FamilyName;

    public TradeData tradeData;

    private void Start()
    {
        renderer2D = this.GetComponent<SpriteRenderer>();
        renderer2D.sprite = tradeData.Sprite;
    }

}
