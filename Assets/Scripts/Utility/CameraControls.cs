using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour {

    public Camera myCam;
    public float moveSpeed;
    public float boundsX;
    public float boundsY;
    public float maxZoom;
    public float minZoom;
    private float axisThreshold = 0.5f;

	void Start()
    {
        if (myCam == null) myCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

      
    }
	// Update is called once per frame
	void Update ()
    {
        float axisRawH = Input.GetAxisRaw("Horizontal");
        float axisRawV = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Z) && myCam.orthographicSize >= minZoom)
        {
            myCam.orthographicSize--;
        }
        else if (Input.GetKeyDown(KeyCode.X) && myCam.orthographicSize <= maxZoom)
        {
            myCam.orthographicSize++;
        }

        if((axisRawH <= -axisThreshold || axisRawH >= axisThreshold) && Mathf.Abs(transform.position.x) <= boundsX)
        {
            this.transform.Translate(new Vector3(axisRawH * moveSpeed,0,0));
        }
        if((axisRawV <= -axisThreshold || axisRawV >= axisThreshold) && Mathf.Abs(transform.position.y) <= boundsY)
        {
            this.transform.Translate(new Vector3(0, axisRawV * moveSpeed, 0));
        }
        //Fix if stuck at galaxy border
        if (transform.position.x >= boundsX )
        {
            transform.Translate(new Vector3(-.5f,0f,0f));
        }
        if (transform.position.x <= -boundsX)
        {
            transform.Translate(new Vector3(.5f, 0f, 0f));
        }
        if (transform.position.y >= boundsY)
        {
            transform.Translate(new Vector3(0f, -.5f, 0f));
        }
        if (transform.position.y <= -boundsY)
        {
            transform.Translate(new Vector3(0f, .5f, 0f));
        }

    }
}
