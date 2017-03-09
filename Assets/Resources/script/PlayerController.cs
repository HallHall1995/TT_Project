using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    Rigidbody rigidbody;

    public float force = 5.0f;
    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.AddForce(Vector3.back * force);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddForce(Vector3.left * force);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddForce(Vector3.forward * force);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddForce(Vector3.right * force);
        }
        
    }
}
