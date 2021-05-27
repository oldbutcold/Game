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