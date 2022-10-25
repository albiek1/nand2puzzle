using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputController : MonoBehaviour
{
    // Start is called before the first frame update
    NandController c1;
    PinController c2;
    public bool value;
    void Start()
    {
        c1 = GetComponentInParent<NandController>();
        c2 = GetComponentInParent<PinController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(c1 != null)
        {
            value = c1.value;
        }
        if(c2 != null)
        {
            value = c2.value;
        }
    }
}
