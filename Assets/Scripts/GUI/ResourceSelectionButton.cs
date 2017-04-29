using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceSelectionButton : MonoBehaviour {

    public Resource resource;
    public Image myImage;
    public Text myText;

	// Use this for initialization
	void Start () {
		
	}
	
	public void SetResource(Resource resource)
    {
        this.resource = resource;
        myImage.sprite = resource.ResourceData.Sprite;
        myText.text = resource.Amount.ToString();
    }
}
