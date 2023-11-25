using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killZonePlatf : MonoBehaviour
{
    public GameObject canvasDead;
    public GameObject CanvasHud;
    public GameObject Obj;


    void OnCollisionEnter2D(Collision2D Col)
    {
        if(Col.gameObject.tag == "Kill" || Col.gameObject.tag == "Kill2")
        {
            Destroy(Obj);
            canvasDead.SetActive (true);
            CanvasHud.SetActive (false);
            Time.timeScale = 0;
        }
    }

}
