using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PanelBase : MonoBehaviour {

    public abstract void AssignContent<T>(T content);
    public abstract void Draw();
    public abstract void Clear();


}
