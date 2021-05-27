using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTeleport : Interactable
{
    public int sceneID;
    private void Update()
    {
        if (playerInRange)
        {
            SceneManager.LoadScene(sceneID);
        }
    }
}