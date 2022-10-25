using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    // Start is called before the first frame update
    public Button nButton;
    public Button wButton;
    public GameController gc;
    void Start()
    {
        Button Nbtn = nButton.GetComponent<Button>();
        Button Wbtn = wButton.GetComponent<Button>();
        Nbtn.onClick.AddListener(selectNand);
        Wbtn.onClick.AddListener(selectWire);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void selectNand()
    {
        gc.getMessage("Nand");
        //Debug.Log("Button has been clicked");
    }
    void selectWire()
    {
        gc.getMessage("Wire");
    }
}
