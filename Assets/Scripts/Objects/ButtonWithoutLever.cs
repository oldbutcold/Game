using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonWithoutLever : MainScript
{
    public bool buttonActive;
    public Sprite pushedButtonSprite;
    private SpriteRenderer mySprite;

    // Start is called before the first frame update
    void Start()
    {
        mySprite = GetComponent<SpriteRenderer>();
        buttonActive = false;
    }

    public void ActivateButton()
    {
        buttonActive = true;
        PushedButtons++;
        mySprite.sprite = pushedButtonSprite;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Rigidbody2D>() == null) return;
        if (buttonActive) 
            return;
        ActivateButton();
    }
}