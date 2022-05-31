using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioListenStartMmenu : MonoBehaviour
{
    public bool soundOn = true;
    
    public void SoundSwitcher()
    {
        if (soundOn == true)
        {
            AudioListener.pause = true;
        }
        else
        {
            AudioListener.pause = false;
        }
    }
   
   
    private void Start()
    {
        GlobalEventManager.soundSwitch = SoundSwitcher;
    }

}
