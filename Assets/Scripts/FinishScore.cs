using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Serialization;


public class FinishScore : MonoBehaviour
{
    public float score;
    public TextMeshProUGUI ScoreText;

    void Update()
    {
        score = PlayerPrefs.GetFloat("Счёт");
        ScoreText.text = score.ToString(CultureInfo.InvariantCulture);
    }
}
