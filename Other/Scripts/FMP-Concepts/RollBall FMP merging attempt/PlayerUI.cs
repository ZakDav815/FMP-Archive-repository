using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public GameObject WinTextObject;

    void Start()
    {
        rb = GetComponent <Rigidbody>(); // Get+Store Rigidbody component on player
        count = 0;

        SetCountText();
        WinTextObject.SetActive(false);
    }
    
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count>= 0)
        {
            WinTextObject.SetActive(true); // When certain no. collected, show win screen
        }
    }
}
