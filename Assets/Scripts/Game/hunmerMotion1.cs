﻿using UnityEngine;
using System.Collections;

public class hunmerMotion1 : MonoBehaviour {

    public Animator anim;
    private int animCnt;
    Transform cameraTransform;
    public float targetDistance;
    public float distance;
    // Use this for initialization
    void Start () {
        animCnt = 0;
        distance = 5000.0f;
        cameraTransform = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
	//if(Input.GetKeyDown(KeyCode.Z))
 //       {
     
 //           if( animCnt == 0 )
 //           {
 //               animCnt = 1;
 //           }
 //           else if( animCnt != 2 )
 //           {
 //               animCnt = 1;
 //           }
 //       }
        distance = transform.position.z - cameraTransform.position.z;
        distance = Mathf.Abs( distance );
        if( distance < targetDistance )
        {
            animCnt = 1;
        }
        anim.SetInteger( "swing" , animCnt );
        if (cameraTransform.position.z < transform.position.z)
        {
            //gameObject.SetActive(false);
            //Destroy(gameObject);
        }
    }
    void OnCollisionEnter( Collision col )
    {
        Debug.Log( "あたり！" );
		SoundManager.PlaySe("GameSE_Break");
		if ( col.gameObject.CompareTag( "Player" ) )
        {
			//GameManager.SetMode( GameManager.Mode.RESULT);
            //Destroy(col.gameObject);
        }
    }
}
