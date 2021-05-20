using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : Interactable
{
    public bool leverActive;
    public Sprite pushedLeverSprite;
    private SpriteRenderer mySprite;
    
    // Start is called before the first frame update
    void Start()
    {
        mySprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerInRange)
        {
            leverActive = !leverActive;
            var x = mySprite.sprite;
            mySprite.sprite = pushedLeverSprite;
            pushedLeverSprite = x;
        }
    }
}
