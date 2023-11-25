using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCanvas : MonoBehaviour
{
    public GameObject canvasObject;

    public void CanvasOn()
    {
        canvasObject.SetActive (true);
    }

    public void CanvasOff()
    {
        canvasObject.SetActive (false);
    }
    
}
