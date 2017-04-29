using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResoucePanel : MonoBehaviour {

    public Resources myResource;

    public Image myImage;
    public Text myText;

    void Update()
    {
        //UpdateMe();
    }

    //public void UpdateMe()
    //{
    //    switch (myResource)
    //    {
    //        case Resources.Cash:
    //       //     UpdateText(CityManager.Instance.Cash.ToString());
    //            break;
    //        case Resources.Wood:
    //       //     UpdateText(CityManager.Instance.Wood.ToString());
    //            break;
    //        case Resources.Wheat:
    //      //      UpdateText(CityManager.Instance.Wheat.ToString());
    //            break;
    //        case Resources.Pops:
    //      //      UpdateText(CityManager.Instance.Pops.ToString());
    //            break;
    //    }
    //}

    public void UpdateText(string str)
    {
        myText.text = str;
    }
    public void UpdateImage(Sprite spr)
    {
        myImage.sprite = spr;
    }


}
