using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum SelectorStatus
{
    OK, Wrong
}

public class Selector : MonoBehaviour {

    public Sprite sprOK;
    public Sprite sprBad;
    SpriteRenderer renderer2D;

    private void Start()
    {
        renderer2D = this.GetComponent<SpriteRenderer>();
        ChangeDecoyStatus(SelectorStatus.OK);
    }

    SelectorStatus _status;

    public void ChangeDecoyStatus(SelectorStatus status)
    {
        _status = status;
        switch (_status)
        {
            case SelectorStatus.OK:
                renderer2D.sprite = sprOK;
                break;
            case SelectorStatus.Wrong:
                renderer2D.sprite = sprBad;
                break;

        }
    }

}
