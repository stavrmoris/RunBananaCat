using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Serialization;


public class Score : MonoBehaviour
{   [Header("Активный Счёт")]
    public int score;
    [Header("Рекордный Счёт")]
    public int RecScore;
    public TextMeshProUGUI scoreText2;

    void Awake()
    {
        StartCoroutine(Bonus());
    }
    void Update()
    {
        scoreText2.text = $"Ваш счёт: {score.ToString(CultureInfo.InvariantCulture)}";
        PlayerPrefs.SetFloat("Счёт", score);
    }
    
    IEnumerator Bonus()
    {
        do
        {yield return new WaitForSeconds(1f);
            score += 1;
        } while (true);
    }
}
