using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;

public class ButtonHub : MonoBehaviour
{
  
    public void Play()
    {
        SceneManager.LoadScene("Game");
        
    }

    public void Back()
    {
        SceneManager.LoadScene("Hub");
    }

    public void Some()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Something()
    {
        SceneManager.LoadScene("Settings");
    }
}
