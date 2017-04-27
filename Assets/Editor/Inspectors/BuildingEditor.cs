using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Building))]
[CanEditMultipleObjects]
public class BuildingEditor : Editor {

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        Building bld = (Building)target;

        if (GUILayout.Button("(Re)draw Building"))
        {
            bld.Render();
        }
    }

}
