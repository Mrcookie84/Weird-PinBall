using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public KeyCode key1 = KeyCode.W;
    public KeyCode key2 = KeyCode.A;
    public KeyCode key3 = KeyCode.S;
    public KeyCode key4 = KeyCode.D;
    
    public Rigidbody rb;
    private float speed = 0.2f;
    
    private void Update()
    {
        if (Input.GetKey(key1))
        {
            transform.localPosition = new Vector3 (transform.position.x, transform.position.y , transform.localPosition.z + speed );
        }

        if (Input.GetKey(key3))
        {
            transform.localPosition = new Vector3 (transform.position.x, transform.position.y , transform.localPosition.z - speed );
            
        }
        
        if (Input.GetKey(key2))
        {
            transform.localPosition = new Vector3 (transform.localPosition.x - speed, transform.position.y , transform.position.z);
            
        }
        
        if (Input.GetKey(key4))
        {
            transform.localPosition = new Vector3 (transform.localPosition.x + speed, transform.position.y , transform.position.z);
            
        }
    }
}