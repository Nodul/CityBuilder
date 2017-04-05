using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BuildDecoyStatus
{
    OK, Wrong
}
/// <summary>
/// The colorful selection thingy to show where a building will be placed
/// </summary>
public class BuildDecoy : MonoBehaviour {

    public Sprite sprOK;
    public Sprite sprBad;
    public Image myImage;

    private static BuildDecoy _instance;
    public static BuildDecoy Instance { get { return _instance; } }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    BuildDecoyStatus _status;

    public void ChangeDecoyStatus(BuildDecoyStatus status)
    {
        _status = status;
        switch (_status)
        {
            case BuildDecoyStatus.OK:
                myImage.sprite = sprOK;
                break;
            case BuildDecoyStatus.Wrong:
                myImage.sprite = sprBad;
                break;

        }
    }


}
