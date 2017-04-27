using UnityEditor;
//
// From the Unity 3D wiki: wiki.unity3d.com/index.php?title=CreateScriptableObjectAsset
//
public class AreaDataAsset
{
    [MenuItem("Assets/Create/Game Data/Area Data")]
    public static void CreateAsset()
    {
        ScriptableObjectUtility.CreateAsset<AreaData>();
    }
}