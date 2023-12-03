using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class killZonePlatf : MonoBehaviour
{
    public GameObject canvasDead;
    public GameObject canvasHud;
    public GameObject[] kill1;
    public GameObject[] kill2;
    public GameObject[] back;
    private SpawnObject _spawn;
    [SerializeField] private Animator anim;
    [SerializeField] private SpawnsFon spawnFon;
    private Animator _anim;

    void Start()
    { 
        _anim = GetComponent<Animator>();
        _spawn = GetComponent<SpawnObject>();
    }

    private void Update()
    {
        kill1 = GameObject.FindGameObjectsWithTag("Kill");
        kill2 = GameObject.FindGameObjectsWithTag("Kill2");
        back = GameObject.FindGameObjectsWithTag("Finish");
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Kill") || col.gameObject.CompareTag("Kill2"))
        {
            Finish();
        }
    }
    
    private void OnTriggerStay2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Kill") || col.gameObject.CompareTag("Kill2"))
        {
            Finish();
        }
    }

    void Finish()
    {
        
        _anim.SetTrigger("cry");
        
        canvasDead.SetActive (true);
        canvasHud.SetActive (false);
        
        Time.timeScale = 0;
    }
}
