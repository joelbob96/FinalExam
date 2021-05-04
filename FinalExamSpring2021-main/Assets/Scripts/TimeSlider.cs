using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSlider : MonoBehaviour
{
    //public static float time;

    void Start()
    {
        GameManager.time = 30f;
    }

    public void setTime(float newtime)
    {
        GameManager.time = newtime;
    }
}
