using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Collections.ObjectModel;
using System;
using UnityEngine.SceneManagement;

public class BackToStartMenu : MonoBehaviour
{
    
    public void backToStartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
