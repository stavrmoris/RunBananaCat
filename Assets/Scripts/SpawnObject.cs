using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{   
    [Header("Кактус")]
    public GameObject objCactus;
    public GameObject objPlatforma;
    public GameObject obj;
    public float PosY;
    public float PosX;
    public bool CanSpawn = true;
    private float RandomTime;
    public Vector3 Pos;

    void Start()
    {   
        CanSpawn = true;
        StartCoroutine(Spawncactus());
        
    }

    IEnumerator Spawncactus()
    {   
        while(true)
        {
            RandomTime = Random.Range(3f, 5f);
            if (Random.value < 0.5f) { 
                obj = objCactus;
                PosY = -3;
            }
            else {
                obj = objPlatforma;
                PosY = -3; 
            }
            Pos = new Vector3(PosX,PosY,0);
            Instantiate(obj, Pos, Quaternion.identity);
            yield return new WaitForSeconds(RandomTime);
        }
    }
}
