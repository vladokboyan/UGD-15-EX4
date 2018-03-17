using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContloreller : MonoBehaviour {

    public float speed;

    private Rigidbody rb;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();   	
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        float moveHorizonantal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizonantal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);    	
    }
}
