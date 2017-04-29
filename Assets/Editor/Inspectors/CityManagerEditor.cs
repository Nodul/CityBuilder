using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CityManager))]
public class CityManagerEditor : Editor
{

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        CityManager man = (CityManager)target;

        if (GUILayout.Button("(Re)populate Resources list"))
        {
            man.PopulateResourceList();
        }

    }

}
