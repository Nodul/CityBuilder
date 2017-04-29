using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceDataMap : ScriptableObject {

    [System.Serializable]
    public class ResourceEntry
    {
        public ResourceData ResourceData;
        public int Amount;
    }

    public List<ResourceEntry> Resources;
}
