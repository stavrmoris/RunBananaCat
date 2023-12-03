using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class SpawnPlatform : MonoBehaviour
{
    public float PosX;
    public Vector2 Pos;
    public GameObject obj;
    void Start()
    {   
        SpawnOnePlatfofm();
    }

    public void SpawnOnePlatfofm()
    {
        PosX = Random.Range(30f, 31f);
        Pos = new Vector2(PosX, -2.41f);
        Instantiate(obj, Pos, Quaternion.identity);
        //SpawnTwoPlatfofm();
    }

    /*public void SpawnTwoPlatfofm()
    {
        PosX = Random.Range(22.56f, 24.97f);
        Pos = new Vector2(PosX,-2.41f);
        Instantiate(obj, Pos, Quaternion.identity);
    }*/


}
// 0.2295047 0.2894617