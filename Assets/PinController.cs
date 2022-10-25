using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinController : MonoBehaviour
{
    // Start is called before the first frame update
    public bool value = false;
    public OutputController output;
    SpriteRenderer rend;
    public GameObject con;
    float fireRate = 0.5f;
    float lastFire = 0.0f;
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        output = GetComponentInChildren<OutputController>();
    }

    // Update is called once per frame
    void Update()
    {
        output.value = value;
    }

    public void OnMouseOver()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time > fireRate + lastFire)
        {
            value = !value;
            Debug.Log(gameObject.name + ": " + value);
            lastFire = Time.time;
        }
    }
}
