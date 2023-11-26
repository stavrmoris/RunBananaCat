using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : MonoBehaviour
{
    public Score _Score;
    public float __Score;
    
    public void Start()
    {

    }
    void Update()
    {
        _Score = GameObject.FindWithTag("Player").GetComponent<Score>();
        __Score = _Score.score;
        PlayerPrefs.SetFloat("Счёт",__Score);
        PlayerPrefs.Save();
    }

}