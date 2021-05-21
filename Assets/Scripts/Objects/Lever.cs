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
        var sprite = GetComponent<SpriteRenderer>();
        sprite.sortingOrder = Mathf.RoundToInt(transform.position.y * -10f - 1);
        if (Input.GetKeyDown(KeyCode.E) && playerInRange)
        {
            leverActive = !leverActive;
            var x = mySprite.sprite;
            mySprite.sprite = pushedLeverSprite;
            pushedLeverSprite = x;
        }
    }
}