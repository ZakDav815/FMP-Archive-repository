using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public Vector3 camOffset = new Vector3(0f, 1f, -2.6f);
    private Transform target;
    void Start() // Start is called once before the first execution of Update after the MonoBehaviour is created
    {
        target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LateUpdate()
    {
        this.transform.position = target.TransformPoint (camOffset);
        this.transform.LookAt (target);
    }
}
