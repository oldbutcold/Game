using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTeleport : Interactable
{
    private void Start()
    {
        
    }

    private void Update()
    {
        if (playerInRange)
        {
            SceneManager.LoadScene("Level 2");
        }
    }
}