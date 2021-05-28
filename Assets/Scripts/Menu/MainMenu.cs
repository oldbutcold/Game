﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Debug.Log("Exited from game!");
        Application.Quit();
    }

    public void Ending()
    {
        Debug.Log("Completed the game!");
        SceneManager.LoadScene(0);
    }
}
