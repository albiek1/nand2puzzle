using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NandController : MonoBehaviour
{
    // Start is called before the first frame update
    public InputController in1;
    public InputController in2;
    public bool input1;
    public bool input2;
    public bool value;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        input1 = in1.value;
        input2 = in2.value;
        if (input1 && input2)
        {
            value = true;
        }
        else
        {
            value = false;
        }
    }
}
