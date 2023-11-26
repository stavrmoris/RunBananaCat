using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Serialization;


public class FinishScore : MonoBehaviour
{
    public float Score;
    public TextMeshProUGUI ScoreText;
    void Start()
    {
        

    }


    void FixedUpdate()
    {
        Score = PlayerPrefs.GetFloat("Счёт");
        ScoreText.text = Score.ToString(CultureInfo.InvariantCulture);
    }
}
