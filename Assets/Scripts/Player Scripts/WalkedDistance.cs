// using System;
// using UnityEngine;
// using UnityEngine.SceneManagement;
//
// public class WalkedDistance : MonoBehaviour
// {
//     private float oldPositionX;
//     private float oldPositionY;
//     public float totalDistanceX;
//     public float totalDistanceY;
//     public float maxDistanceX;
//     public float maxDistanceY;
//
//     void Start()
//     {
//         var position = transform.position;
//         oldPositionX = position.x;
//         oldPositionY = position.y;
//     }
//
//     void FixedUpdate()
//     {
//         var position = transform.position;
//         
//         var newPositionX = position.x;
//         var subDistanceX = totalDistanceX;
//         totalDistanceX += Math.Abs(newPositionX - oldPositionX);
//         oldPositionX = newPositionX;
//         if (subDistanceX == totalDistanceX && subDistanceX != 0)
//             totalDistanceX = 0;
//         
//         var newPositionY = position.y;
//         var subDistanceY = totalDistanceY;
//         totalDistanceY += Math.Abs(newPositionY - oldPositionY);
//         oldPositionY = newPositionY;
//         if (subDistanceY == totalDistanceY && subDistanceY != 0)
//             totalDistanceY = 0;
//         
//         if (totalDistanceX >= maxDistanceX || totalDistanceY >= maxDistanceY)
//         {
//             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
//         }
//     }
// }

using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WalkedDistance : MonoBehaviour
{
    private Vector3 oldPosition;
    public float totalDistanceX;
    public float totalDistanceY;
    public float maxDistanceX;
    public float maxDistanceY;

    public GameObject enemy;
    private bool isEnemySpawned = false;

    void Start()
    {
        oldPosition = transform.position;
    }

    void Update()
    {
        UpdateDistance();
        if ((totalDistanceX >= maxDistanceX || totalDistanceY >= maxDistanceY) && 
            isEnemySpawned == false)
        {
            Instantiate(enemy, enemy.transform.position, Quaternion.identity);
            isEnemySpawned = true;
        }
    }

    void UpdateDistance()
    {
        var position = transform.position;
        var distanceX = Mathf.Abs(position.x - oldPosition.x);
        var distanceY = Mathf.Abs(position.y - oldPosition.y);

        totalDistanceX += distanceX;
        totalDistanceY += distanceY;

        oldPosition = position;

        if (distanceX == 0 && distanceY > 0.05)
        {
            totalDistanceX = 0;
        }

        if (distanceX > 0.05 && distanceY == 0)
        {
            totalDistanceY = 0;
        }
    }
}