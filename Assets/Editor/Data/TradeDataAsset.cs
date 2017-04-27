using UnityEditor;

public class TradeDataAsset  {

    [MenuItem("Assets/Create/Game Data/Trade Data")]
    public static void CreateAsset()
    {
        ScriptableObjectUtility.CreateAsset<TradeData>();
    }
}
