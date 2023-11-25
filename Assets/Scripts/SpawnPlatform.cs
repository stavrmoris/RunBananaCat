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
        PosX = Random.Range(15, 18);
        Pos = new Vector2(PosX,-1);
        Instantiate(obj, Pos, Quaternion.identity);
        SpawnTwoPlatfofm();
    }

    public void SpawnTwoPlatfofm()
    {
        PosX = Random.Range(19, 25);
        Pos = new Vector2(PosX,-1);
        Instantiate(obj, Pos, Quaternion.identity);
    }


}
// 0.2295047 0.2894617