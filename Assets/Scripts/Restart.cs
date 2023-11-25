using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart: MonoBehaviour
{
    public GameObject canvasObject;
    public GameObject TwoCanvas;
    

    public void CanvasOn()
    {
        canvasObject.SetActive (true);
        TwoCanvas.SetActive (false);
        
    }

    public void CanvasOff()
    {
        canvasObject.SetActive (false);
        TwoCanvas.SetActive (true);
    }
    
}
