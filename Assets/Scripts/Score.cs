using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public static int score;
    private Text scoreTxt;
   
    void Start()
    {
        scoreTxt = GetComponent<Text>();
        score = 0;
        
    }

    void Update()
    {
        scoreTxt.text = score.ToString();
    }


   
}
