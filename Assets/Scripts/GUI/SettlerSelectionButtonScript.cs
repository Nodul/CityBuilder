using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettlerSelectionButtonScript : MonoBehaviour {

    public Settler Settler;
    public Image myImage;
    public Text myText;

    private void Start()
    {
        //myImage = this.GetComponentInChildren<Image>();
       // myText = this.GetComponentInChildren<Text>();
    }

    public void SelectSettler()
    {
        UIManager.Instance.UISelectSettler(this.Settler);
    }

    public void SetSettler(Settler settler)
    {
        this.Settler = settler;
        myImage.sprite = settler.tradeData.Sprite;
        myText.text = settler.FamilyName + ", " + settler.tradeData.Name;
    }

}
