using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCheck : MonoBehaviour
{
    
    public Text timeText;
    float sec;
    float min;
    void Start()
    {
        timeText.text = min.ToString()+'.'+ sec.ToString();
    }

   
    void Update()
    {
        sec += Time.deltaTime;
        if (sec>59)
        {
            sec = 0;
            min++;
        }
        timeText.text = min.ToString() + '.' + Mathf.Round(sec).ToString();
    }
}
