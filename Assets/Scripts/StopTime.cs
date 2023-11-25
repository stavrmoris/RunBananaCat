using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTime : MonoBehaviour
{

    public void Stop()
    {
        Time.timeScale = 0;
    }

    public void startt()
    {
        Time.timeScale = 1;
    }

}
