using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : Interactable
{
    public GameObject player;
    public GameObject enemy;
    public float speed;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        enemy.transform.position = Vector2.MoveTowards(enemy.transform.position,
            player.transform.position, speed * Time.deltaTime);
        if (playerInRange)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}