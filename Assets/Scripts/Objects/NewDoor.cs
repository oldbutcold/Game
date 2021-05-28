using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDoor : MainScript
{
    public bool open = false;
    public SpriteRenderer doorSprite;
    public BoxCollider2D physicsCollider;

    public void DoorOpen()
    {
        //Turn off the door's sprite renderer
        doorSprite.enabled = false;
        //set open to true
        open = true;
        //turn off the door's box collider
        physicsCollider.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (PushedButtons == 4)
            DoorOpen();
    }
}
