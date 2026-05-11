using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;
    private Vector3 offset; // dist between cam & Player
    
    void Start()// Start called before 1st frame update
    {
        offset = transform.position - Player.transform.position; // calc initial offset betweem cam & Player's position.
    }

    void LateUpdate() // LateUpdate called once per frame after all Update fuctions have been completed
    {
       transform.position = Player.transform.position + offset; // maintain same offset between cam & Player throughout game
    }
}
