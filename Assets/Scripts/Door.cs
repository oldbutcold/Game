using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Door : MonoBehaviour, IDoor
{
    public SpriteRenderer spriteRenderer;
    public Sprite openedDoorSprite;
    public Sprite closedDoorSprite;
    
    // Start is called before the first frame update
    void Start()
    {
        CloseDoor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenDoor()
    {
        spriteRenderer.sprite = openedDoorSprite;
    }

    public void CloseDoor()
    {
        spriteRenderer.sprite = closedDoorSprite;
    }
}
