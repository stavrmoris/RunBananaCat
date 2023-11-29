using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnsFon : MonoBehaviour
{
    public GameObject[] Clouds;
    public GameObject[] Brushes;
    void Start()
    {   
        StartCoroutine(CloudsCoroutine());
        StartCoroutine(BrushesCoroutine());
    }

    void Update()
    {
        
    }

    IEnumerator CloudsCoroutine()
    {
        while(true)
        {
            var randPosY = Random.Range(3f, 7f);
            var pos = new Vector3(28, randPosY, 0);
            Instantiate(Clouds[Random.Range(0, Clouds.Length)], pos, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(3f, 7f));
        }
    }
    
    IEnumerator BrushesCoroutine()
    {
        while(true)
        {
            var pos2 = new Vector3(28, -3.2f, 0);
            Instantiate(Brushes[Random.Range(0, Brushes.Length)], pos2, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(0.4f, 3f));
        }
    }
}