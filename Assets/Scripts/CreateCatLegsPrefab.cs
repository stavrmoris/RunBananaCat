using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCatLegsPrefab : MonoBehaviour
{
    public GameObject catLegs;
    
    void Start()
    {
        StartCoroutine(SpawnLegs());
    }

    IEnumerator SpawnLegs()
    {   
        while(true)
        {
            var randomTime = Random.Range(10f, 60f);
            yield return new WaitForSeconds(randomTime);
            Instantiate(catLegs, transform.position, transform.rotation);
        }
    }
}
