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
    private Animator _animator;
    private Vector2 _vector;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        if (WalkedDistance.isEnemyAngry)
        {
            _animator.SetBool("moving", true);
            if (Vector2.Distance(enemy.transform.position, player.transform.position) < 0.1)
            {
                WalkedDistance.isEnemyAngry = false;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            else
            {
                _vector = Vector2.MoveTowards(enemy.transform.position,
                    player.transform.position, speed * Time.deltaTime);
                if (enemy.transform.position.x - player.transform.position.x < 0)
                    _animator.SetFloat("moveX", 1);
                else
                    _animator.SetFloat("moveX", -1);
                enemy.transform.position = _vector;
            }
        }
        else
        {
            _animator.SetBool("moving", false);
            if (enemy.transform.position.x - player.transform.position.x < 0)
                _animator.SetFloat("moveX", 1);
            else
                _animator.SetFloat("moveX", -1);
        }
    }
}