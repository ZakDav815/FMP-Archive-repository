using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public Transform Player;
    public Transform parentObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Player == null) Player = other.transform; // 
            Player.parent = parentObject; // set parent to parent object
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Player == null) Player = other.transform;
            Player.parent = null; // set player back to worldspace when leave platform.
        }
    }
}
