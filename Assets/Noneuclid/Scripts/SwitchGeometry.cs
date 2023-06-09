using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class SwitchGeometry : MonoBehaviour
{
    GeometryControl geomControl;
    public Button EuclideanPressed;
    Material Geom;

    void Start()
    {
        Geom = Resources.Load("Noneuclidean/Materials/Standard Material", typeof(Material)) as Material;
        if (geomControl == null)
        {
            geomControl = FindObjectOfType<GeometryControl>();
        }
        if (geomControl == null)
        {
            enabled = false;
        }
    }

    void Update()
    {
       
    }

    public void EuclideanSwitch()
    {
        SceneManager.LoadScene("PresentationScene");
        Debug.Log("Euclidean switch");
    }

    public void HyperbolicSwitch()
    {
        SceneManager.LoadScene("HyperbolicScene");
        Debug.Log("HyperbolicSwitch");
    }

    public void EllipticSwitch()
    {
        SceneManager.LoadScene("ElipticScene");
        Debug.Log("EllipticSwitch");
    }
}
