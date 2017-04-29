using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CityManager : MonoBehaviour
{

    private static CityManager _instance;
    public static CityManager Instance { get { return _instance; } }

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

    private void Start()
    {
        if (PopulateResourceListAtStart) PopulateResourceList();
    }

    public List<Resource> CityResources;
    public bool PopulateResourceListAtStart;

    public void PopulateResourceList()
    {
        CityResources.Clear();
        var resources = Resources.LoadAll("Resources/");

        foreach (ResourceData data in resources)
        {
            Resource res = new Resource() { ResourceData = data, Amount = data.StartingValue, Name = data.Name};
            CityResources.Add(res);
        }
    }

}
