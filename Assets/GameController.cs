using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Events;

public class GameController : MonoBehaviour
{
    public GameObject prefab;
    float fireRate = 0.5f;
    float lastShot = 0.0f;
    public float dragSpeed = 2f;
    public Vector3 dragOrigin;
    public Vector3 cameraOrigin;
    public bool cameraDragging = true;
    public String buttonClicked = "button has been clicked";
    public int itemSelected = 0;
    public String currSelected = "none";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetKey(KeyCode.Mouse0) && Time.time > fireRate + lastShot)
        {
            Vector3 v3 = new Vector3(Mathf.Round(Camera.main.ScreenToWorldPoint(Input.mousePosition).x*4)/4,
                                     Mathf.Round(Camera.main.ScreenToWorldPoint(Input.mousePosition).y*4)/4,
                                     0);
            GameObject obj = Instantiate(prefab, v3, Quaternion.identity) as GameObject;
            obj.transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y, 0);
            lastShot = Time.time;
        }*/

        if (Input.GetMouseButtonDown(1))
        {
            cameraDragging = true;
            dragOrigin = transform.position;
            cameraOrigin = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        }

        if (Input.GetMouseButton(1))
        {
            Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition) - cameraOrigin;
            transform.position = dragOrigin + -pos * dragSpeed;
        }

        if (Input.GetMouseButtonUp(1))
        {
            cameraDragging = false;
        }
    }

    public void getMessage(String name)
    {
        switch (name)
        {
            case ("Nand"):
                if(itemSelected == 1)
                {
                    itemSelected = 0;
                    currSelected = "none";
                    break;
                }
                else
                {
                    itemSelected = 1;
                    currSelected = name;
                    break;
                }

            case ("Wire"):
                if(itemSelected == 2)
                {
                    itemSelected = 0;
                    currSelected = "none";
                    break;
                }
                else
                {
                    itemSelected = 2;
                    currSelected = name;
                    break;
                }
        }
        Debug.Log("Swapped to " + currSelected);
    }
}
