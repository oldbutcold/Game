using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Player : MonoBehaviour {
    public float speed = 5;
    public GameObject player;
 
    void Start()
    {
        player = gameObject; //тут присваиваем персонажа к игровому Object или как-то так.
    }
    
    // Ах да вместо player надо ставить имя твоего перса которое записано в Unity;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            player.transform.position += player.transform.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.transform.position -= player.transform.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position += player.transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position -= player.transform.right * speed * Time.deltaTime;//персонаж плавно двигается на W,S,D,A;
        }                                              //всё легко и просто, как борщ(всё как Вы и просили)
    }
}
