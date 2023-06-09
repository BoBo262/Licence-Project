using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using JetBrains.Annotations;

public class ImageLoader : MonoBehaviour
{
    public Sprite SlideSprite1;
    public Sprite SlideSprite2;
    public Sprite SlideSprite3;
    public Sprite SlideSprite4;
    public Sprite SlideSprite5;
    public Sprite SlideSprite6;
    public Sprite SlideSprite7;
    public Sprite SlideSprite8;
    
    private int number;
    [SerializeField] private InputActionReference PressAction;
  

    // Start is called before the first frame update
    void Start()
    {
        number = 0;
        
    }

    // Update is called once per frame
    void Update()
    {

        PressAction.action.performed += OnPressed;
       

        Debug.Log(number);

        switch (number)
        {
            case 1:
                this.transform.GetComponent<UnityEngine.UI.Image>().sprite = SlideSprite1;
                break;
            case 2:
                this.transform.GetComponent<UnityEngine.UI.Image>().sprite = SlideSprite2;
                break;
            case 3:
                this.transform.GetComponent<UnityEngine.UI.Image>().sprite = SlideSprite3; ;
                break;
            case 4:
                this.transform.GetComponent<UnityEngine.UI.Image>().sprite = SlideSprite4;
                break;
            case 5:
                this.transform.GetComponent<UnityEngine.UI.Image>().sprite = SlideSprite5;
                break;
            case 6:
                this.transform.GetComponent<UnityEngine.UI.Image>().sprite = SlideSprite6; ;
                break;
            case 7:
                this.transform.GetComponent<UnityEngine.UI.Image>().sprite = SlideSprite7;
                break;
            case 8:
                this.transform.GetComponent<UnityEngine.UI.Image>().sprite = SlideSprite8;
                break;
            default:
                number=1;
                break;
        }

    }

    void OnPressed(InputAction.CallbackContext obj)
    {
        number++;
        Debug.Log("was pressed");
    }
}
