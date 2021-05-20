using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : Interactable
{
    public bool leverActive;
    public Sprite pushedLeverSprite;
    private SpriteRenderer mySprite;
    private GameObject player;
    private GameObject lever;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        lever = GameObject.FindWithTag("Lever");
        mySprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        var sprite = GetComponent<SpriteRenderer>();
        sprite.sortingOrder = Mathf.RoundToInt(transform.position.y * -10f);
        if (player is null || lever is null) return;
        if (Input.GetKeyDown(KeyCode.E) && Vector3.Distance(player.transform.position, lever.transform.position) < 1)
        {
            leverActive = !leverActive;
            var x = mySprite.sprite;
            mySprite.sprite = pushedLeverSprite;
            pushedLeverSprite = x;
        }
        
    }
}
