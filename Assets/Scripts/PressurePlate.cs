using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField] private GameObject doorGameObject;
    private float timer;
    private IDoor door;
    
    public SpriteRenderer spriteRenderer;
    public Sprite pressedSprite;
    public Sprite notPressedSprite;

    private void Awake()
    {
        door = doorGameObject.GetComponent<IDoor>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                door.CloseDoor();
                spriteRenderer.sprite = notPressedSprite;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D x)
    {
        if (x.GetComponent<Rigidbody2D>() != null)
        {
            door.OpenDoor();
            timer = 1;
            PlatePressed();
        }
    }

    // private void OnTriggerStay2D(Collider2D x)
    // {
    //     if (x.GetComponent<Rigidbody2D>() != null)
    //     {
    //         timer = 1;
    //         PlatePressed();
    //     }
    // }

    private void PlatePressed()
    {
        spriteRenderer.sprite = pressedSprite;
    }
}

public interface IDoor
{
    void OpenDoor();
    void CloseDoor();
}
