using UnityEngine;
using System.Collections;

public class hunmer02top : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }
    void OnCollisionEnter( Collision other )
    {
            Debug.Log( "あたり！" );
            if( other.gameObject.CompareTag( "Player" ) )
            {
                Destroy( other.gameObject );
            }
        }
}
