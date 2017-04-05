using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UIMode
{
    Default,
    Build
}

public class UIManager : MonoBehaviour {

    private static UIManager _instance;
    public static UIManager Instance { get { return _instance; } }

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

    public UIMode uiMode;
    public UIMode UIMode
    {
        get { return uiMode; }
    }

    public BuildDecoy BuildingDecoy; //a green field/something to show where will the building be constructed
    public GameObject tooltipPanel;
    //public GameObject Building

    RaycastHit2D hit;
    Vector2 camPoint;
    Vector2 mouse;

    void Start()
    {
        //if (starWindow == null) starWindow = GameObject.FindObjectOfType<StarWindow>().GetComponent<StarWindow>();
        //if (empireWindow == null) empireWindow = GameObject.FindObjectOfType<EmpireWindow>().GetComponent<EmpireWindow>();
    }
    //This probably isn't needed for now. TODO also add graphical indicator [circle or something]
    #region //Selection indicator
    /*
    public Selectable currentSelection;
    public Selectable CurrentSelection
    {
        get { return currentSelection; }
        set
        {
            if (currentSelection != null) currentSelection.GetDeselected();
            currentSelection = value;
            currentSelection.GetSelected();
        }
    }
    */
    #endregion

    public void MonthlyUpdate()
    {
        //if (starWindow.isActiveAndEnabled) starWindow.Draw();
       // if (empireWindow.isActiveAndEnabled) empireWindow.Draw();
        //Debug.Log("Firing monthly UIManager update!");
    }

  
    void Update()
    {
        mouse = Input.mousePosition;
        switch (uiMode)
        {
            case UIMode.Default:
                break;
            case UIMode.Build:
                HandleBuildMode();
                break;
        }
        HandleTooltip();
        
    }
    void FixedUpdate()
    {
        camPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        hit = Physics2D.Raycast(new Vector2(camPoint.x,camPoint.y),Vector2.zero,0f);

        if(hit.collider != null)
        {
            Debug.Log(hit.transform.name);
        }  
    }

    void HandleTooltip()
    {
        //if(hit.collider.GetComponent<Tool>)
        RectTransform rect = tooltipPanel.GetComponent<RectTransform>();
        tooltipPanel.transform.position = new Vector2(mouse.x + rect.rect.width/3, mouse.y - rect.rect.height/3);
    }

    public void ChangeMode(UIMode mode)
    {
        uiMode = mode;
        switch (mode)
        {
            case UIMode.Default:
                BuildingDecoy.gameObject.SetActive(false);
                break;
            case UIMode.Build:
                BuildingDecoy.gameObject.SetActive(true);
                break;
        }
    }

    void HandleBuildMode()
    {
        //Vector2 mouse = Input.mousePosition;
        //if(hit.collider != null) BuildingDecoy.transform.position = new Vector3(hit.transform.position.x, hit.transform.position.y, 0);
        BuildingDecoy.transform.position = new Vector3(mouse.x, mouse.y, 0);

        if (hit.collider != null)
        {
            BuildingDecoy.gameObject.SetActive(true);
            if (hit.transform.GetComponent<Tile>())
            {
                Tile tl = hit.transform.GetComponent<Tile>();
                if (tl.IsBlocking == false && tl.IsOccupied == false)//found empty space
                {
                    BuildingDecoy.ChangeDecoyStatus(BuildDecoyStatus.OK);
                    if (Input.GetMouseButtonDown(0))
                    {
                        if (BuildingManager.Instance.CheckIfEligibleToBuild(tl))
                        {
                            Building bld = BuildingManager.Instance.ConstructBuilding(tl);
                            tl.AssignBuilding(bld);
                        }
                        else
                        {
                            Debug.Log("Not enough resources to build");
                        }
                    }
                    
                }
                else
                {
                    BuildingDecoy.ChangeDecoyStatus(BuildDecoyStatus.Wrong);
                    if (Input.GetMouseButtonDown(0))
                    {
                        Debug.Log("Cannot construct building, this tile is already occupied!");
                    }
                    else if (Input.GetMouseButtonDown(2))
                    {
                        BuildingManager.Instance.DeconstructBuilding(tl);
                        Debug.Log("Destroyed building");
                    }
                }
            }
        }
        else
        {
            BuildingDecoy.gameObject.SetActive(false);
        }

        if (Input.GetMouseButtonDown(0))
        {
         
        }
        else if (Input.GetMouseButtonDown(1))
        {
            ChangeMode(UIMode.Default);
        }
      
    }
    /// <summary>
    /// Round to snap grid
    /// </summary>
    /// <param name="input"></param>
    /// <param name="snapValue"></param>
    /// <returns></returns>
    float RoundSnap(float input, float snapValue = 1)
    {       
      return snapValue * Mathf.Round(input/snapValue);
    }
}
