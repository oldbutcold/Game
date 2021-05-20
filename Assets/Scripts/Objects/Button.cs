using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public bool buttonActive;
    public Sprite pushedButtonSprite;
    private SpriteRenderer mySprite;
    public Door thisDoor;
    public Lever thisLever;

    // Start is called before the first frame update
    void Start()
    {
        mySprite = GetComponent<SpriteRenderer>();
        buttonActive = false;
    }

    public void ActivateButton()
    {
        buttonActive = true;
        thisDoor.DoorOpen();
        mySprite.sprite = pushedButtonSprite;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Rigidbody2D>() == null) return;
        if (buttonActive) 
            return;
        if (!thisLever.leverActive)
            SceneManager.LoadScene("Level 1");
        ActivateButton();
    }
}
