using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    [Header("Номер Сцены запускав")]
    public int NumberScene;

    public void Load()
    {
        SceneManager.LoadScene(NumberScene);
        Time.timeScale = 1;

    }
}
