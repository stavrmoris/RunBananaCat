using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnnCanvas : MonoBehaviour
{   [Header("Pause canvas")]
    public GameObject canvassPause;
    [Header("Главный canvas")]
    public GameObject HudCanvassOff;
// Здесь были баги из-за названия переменных, пришлось сделать немного странные.

    public void PauseOn()
    {
        canvassPause.SetActive (true);
        HudCanvassOff.SetActive (false);
         Time.timeScale = 0;
    }

    public void PauseOff()
    {
        canvassPause.SetActive (false);
        HudCanvassOff.SetActive (true);
        Time.timeScale = 1;
    }
    
}
