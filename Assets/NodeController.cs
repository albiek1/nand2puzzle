using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeController : MonoBehaviour
{
    // Start is called before the first frame update
    public bool value;
    public InputController input;
    public OutputController output;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        value = output.value;
        input.value = value;
    }
}
