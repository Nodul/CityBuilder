using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ResourceDataAsset {

    [MenuItem("Assets/Create/Game Data/Resource Data")]
    public static void CreateAsset()
    {
        ScriptableObjectUtility.CreateAsset<ResourceData>();
    }
}
