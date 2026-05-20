using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _WinText;
    [SerializeField] private TextMeshProUGUI _CountText;
    private float Collectable = 0;

    public void Get()
    {
        Collectable += 1;
        _CountText.SetText("Counter: {0} of 4", Collectable);
        if(Collectable == 4)
        {
            _WinText.SetText("Win");
        }
    }

}
