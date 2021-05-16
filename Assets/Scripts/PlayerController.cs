using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Animator _animator;
    public float speed;
    private Rigidbody2D myRigibody;
    private Vector3 change;
    

    void Start()
    {
        myRigibody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        Move();
    }

    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxis("Horizontal");
        change.y = Input.GetAxis("Vertical");
        if (change != Vector3.zero)
        {
            Move();
        }
    }

    void Move()
    {
        myRigibody.MovePosition(transform.position + change * speed * Time.deltaTime);
    }
}