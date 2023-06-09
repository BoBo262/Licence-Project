using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonController : MonoBehaviour
{
    public XRController rController;
    public InputHelpers.Button button;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        bool value = ItemPress();

        if (value)
        {
            Debug.Log("Hello - " + button);
        }

    }

    public bool ItemPress()
    {
        bool buttonValue;
        rController.inputDevice.IsPressed(button, out buttonValue);
        return buttonValue;
    }
}
