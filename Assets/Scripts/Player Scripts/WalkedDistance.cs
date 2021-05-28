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
    public static bool isEnemyAngry = false;

    void Start()
    {
        oldPosition = transform.position;
        Instantiate(enemy, enemy.transform.position, Quaternion.identity);
    }

    void Update()
    {
        UpdateDistance();
        if ((totalDistanceX >= maxDistanceX || totalDistanceY >= maxDistanceY) && 
            isEnemyAngry == false)
        {
            isEnemyAngry = true;
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

        if (distanceX == 0 && distanceY > 0.01)
        {
            totalDistanceX = 0;
        }

        if (distanceY == 0 && distanceX > 0.01)
        {
            totalDistanceY = 0;
        }
    }
}