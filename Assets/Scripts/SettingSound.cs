using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Collections.ObjectModel;
using System;

public class SettingSound : MonoBehaviour
{
    public Text _text;
    public AudioListener AL;
    
    public void SoundOn()
    {
        if (AL.enabled == true)
        {

            GlobalEventManager.soundSwitch();
            _text.text = "Sound Off";
            

        }
       
        else
        {
            GlobalEventManager.soundSwitch();
            _text.text = "Sound On";
            
        }
    }

    public void SoundSwitcher()
    {
        if (AL.enabled == true)
        {
            AL.enabled = false;
        }
        else
        {
            AL.enabled = true;
        }
    }


    private void Start()
    {
        GlobalEventManager.soundSwitch = SoundSwitcher;
    }


    void Update()
    {
        if (AL.enabled == true)
        {

           
            _text.text = "Sound On";


        }

        else
        {

            _text.text = "Sound Off";

        }
    }
}
