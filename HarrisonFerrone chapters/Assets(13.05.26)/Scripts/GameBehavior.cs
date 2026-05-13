// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine.SceneManagement;
// using UnityEngine;

// public class GameBehavior : MonoBehaviour
// {
//     public int maxItems = 4;
//     private int _itemsCollected = 0;
//     private GameBehavior _gameManager;
//     private Rigidbody _rb;
//     private CapsuleCollider _col;

//     void Start()
//     {
//         _rb = GetComponent<Rigidbody>();
//         _col = GetComponent<CapsuleCollider>();

//         _gameManager = gameObject.Find("Game Manager").GetComponent<GameBehavior>();
//     }

//     void OnCollisionEnter(Collision collision)
//     {
//         if(collision.gameObject.name = "Enemy")
//         {
//             _gameManager.HP -= 1;
//             Debug.Log("Player has taken damage");
//         }
//     }

//     public int Items // Item collection code
//     {
//         get
//         {
//             return _itemsCollected; // returns value from _itemmsCollected whenever Items are accessed from outside classes
//         }
        
//         set // assigns new value to _itemsCollected when updated
//         {
//             _itemsCollected = value;
//             Debug.LogFormat("Items: {0}", _itemsCollected); // prints modified value of _itemsCollected in Console
//         }
//     }

//     private int _playerHP = 10;

//     public int HP // HP code
//     {
//         get
//         {
//             return _playerHP;
//         }
//         set
//         {
//             _playerHP = value;
//             Debug.LogFormat("Lives: {0}", _playerHP);
//         }
//     }

// }
