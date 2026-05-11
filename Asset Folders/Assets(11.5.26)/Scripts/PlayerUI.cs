using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public GameObject WinTextObject;
    private Rigidbody rb;
    private int count;

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
        if(count>= 10)
        {
            WinTextObject.SetActive(true); // When certain no. collected, show win screen
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            other.gameObject.SetActive(false); // Player collide with collectable -> deactivate collectable when collide
            count = count + 1;
            {
                SetCountText(); // increase number in UI when touch collectable
            }
        }
    }
}
