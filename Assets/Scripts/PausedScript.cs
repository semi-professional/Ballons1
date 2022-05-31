using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausedScript : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static bool SettingMenuIsActive = false;
    public GameObject PauseMenu;
    public GameObject SettingMenu;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused == false)
            {
                Paused();
            }
            
            else if (SettingMenuIsActive == true)
            {
                settingMenuIsActive();
            }

            else if (GameIsPaused == true & SettingMenuIsActive == false)
            {
                Resume();
            }
            
                
            
        }
    }
    public void settingMenuIsActive()
    {
        if (SettingMenuIsActive == true)
        {
            SettingMenuIsActive = false;
            SettingMenu.SetActive(false);
        }
        else
        {
            SettingMenuIsActive = true;
            SettingMenu.SetActive(true);
        }
    }
    public void Paused()
    {
        Time.timeScale = 0f;
        PauseMenu.SetActive(true);
        GameIsPaused = true;
    }
    public void Resume()
    {
        Time.timeScale = 1f;
        PauseMenu.SetActive(false);
        GameIsPaused = false;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
