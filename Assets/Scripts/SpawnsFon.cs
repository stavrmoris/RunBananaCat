using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnsFon : MonoBehaviour
{
    public GameObject obj;
    private Vector2 Pos;
    private float randPosY;
    void Start()
    {   
        StartCoroutine(TestCoroutine());
    }

    void Update()
    {
        
    }

    IEnumerator TestCoroutine()
    {
        while(true)
        {
            randPosY = Random.Range(3f, 7f);
            Pos = new Vector3(13, randPosY, 0);
            Instantiate(obj, Pos, Quaternion.identity);
            yield return new WaitForSeconds(5f);
        }
    }
}