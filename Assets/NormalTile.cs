﻿using UnityEngine;
using System.Collections;

public class NormalTile : MonoBehaviour {

    Transform cameraTransform;

	// Use this for initialization
	void Start () {
        cameraTransform = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void FixedUpdate() {
	    
        if(cameraTransform.position.z < transform.position.z )
        {
            //gameObject.SetActive(false);
            //Destroy(gameObject);
        }
	}
}