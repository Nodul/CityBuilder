using UnityEditor;

public class BuildingDataAsset  {

    [MenuItem("Assets/Create/Game Data/Building Data")]
    public static void CreateAsset()
    {
        ScriptableObjectUtility.CreateAsset<BuildingData>();
    }
}
