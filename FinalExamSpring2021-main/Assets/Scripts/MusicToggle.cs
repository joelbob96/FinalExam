using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicToggle : MonoBehaviour
{
    //private AudioSource myAudio;
    public GameObject music;
    public Toggle toggle;

    public void Awake()
    {
        if (!PlayerPrefs.HasKey("music"))
        {
            PlayerPrefs.SetInt("music", 0);
            toggle.isOn = false;
            music.SetActive(false);
            PlayerPrefs.Save();
        }
        // 2
        else
        {
            if (PlayerPrefs.GetInt("music") == 0)
            {
                music.SetActive(false);
                toggle.isOn = false;
            }
            else
            {
                music.SetActive(true);
                toggle.isOn = true;
            }
        }
    }

    public void OnToggle(bool selection)
    {
        music.SetActive(selection);
        int i;
        if (selection)
        {
            i = 1;
        }
        else
        {
            i = 0;
        }
        PlayerPrefs.SetInt("music", i);
        PlayerPrefs.Save();
    }
}
