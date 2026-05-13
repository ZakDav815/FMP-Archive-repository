using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public float onscreenDelay = 3f; // changable

    void Start()
    {
        Destroy(this.gameObject, onscreenDelay); // after (set time in onscreenDelay), destroy GameObject
    }
}
