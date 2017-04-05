using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Close and open a panel
/// </summary>
public class TogglePanel : MonoBehaviour {

	
    public void ToggleThisPanel()
    {
        this.gameObject.SetActive(!this.gameObject.activeSelf);
    }


}
