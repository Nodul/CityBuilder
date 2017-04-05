using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Holds info and useful methods concerning all available buildings
/// </summary>
public class BuildingManager : MonoBehaviour
{
    private static BuildingManager _instance;
    public static BuildingManager Instance { get { return _instance; } }

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

    void Start()
    {
        buildingContainer = GameObject.FindGameObjectWithTag("BuildingsContainer");
    }

    GameObject buildingContainer;
    public List<GameObject> BuildingsList = new List<GameObject>(); //prefabs of available buildings

    public Building BuildingSelectedForConstruction; //this is actually a reference to a prefab from the BuildingsList

    public void SetBuildingForConstruction(Building build)
    {
        BuildingSelectedForConstruction = build;
    }

    /// <summary>
    /// Constructs currently selected building
    /// </summary>
    public Building ConstructBuilding(Tile tile)
    {
        if(BuildingSelectedForConstruction != null)
        {
            GameObject newB = Instantiate(
                BuildingSelectedForConstruction.gameObject, 
                tile.transform.position, 
                Quaternion.identity, 
                buildingContainer.transform);

            Building build = newB.GetComponent<Building>();
            tile.AssignBuilding(build);

            CityManager.Instance.Cash -= build.CashBuild;
            CityManager.Instance.Wood -= build.WoodBuild;

            return build;
        }
        else
        {
            throw new UnassignedReferenceException("Tried to construct building without selecting what to construct");
        }
    }
    public void DeconstructBuilding(Tile tile)
    {
        if(tile.MyBuilding != null)
        {
            tile.UnassignBuilding();
        }
    }
    /// <summary>
    /// Check if building can be built on input tile [Check available resources]
    /// </summary>
    /// <param name="tile"></param>
    /// <returns></returns>
    public bool CheckIfEligibleToBuild(Tile tile)
    {
        //I input Tile anyway, because it's possible it will be needed when multiple tile buildings are created
        Building bld = BuildingSelectedForConstruction;
        if(CityManager.Instance.Cash >= bld.CashBuild && CityManager.Instance.Wood >= bld.WoodBuild)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
