using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTeleport : Interactable
{
    // Start is called before the first frame update
    void Start()
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