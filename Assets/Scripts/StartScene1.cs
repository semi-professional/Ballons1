using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScene1 : MonoBehaviour
{
    public void PressStart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
