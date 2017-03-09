using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriPlayerController : MonoBehaviour {

    public float speed;

    private Rigidbody rb;

	void Start ()
    {
        rb = GetComponent<Rigidbody> ();
	}


	void FixedUpdate ()
    {
        float fHorizontalMove = Input.GetAxis("Horizontal");
        float fVerticalMove = Input.GetAxis("Vertical");

        Vector3 vMovement = new Vector3(-fHorizontalMove, 0.0f, -fVerticalMove);

        rb.AddForce(vMovement * speed);
    }
}
