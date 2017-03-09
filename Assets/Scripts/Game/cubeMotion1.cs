using UnityEngine;
using System.Collections;

public class cubeMotion1 : MonoBehaviour {

    private Animator animator;
    public float targetDistance;
    public float distance;
    Transform cameraTransform;
    // Use this for initialization
    void Start () {
       animator = GetComponent<Animator>();
        distance = 5000.0f;
        cameraTransform = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update() {
        //if( Input.GetKey( KeyCode.Space ) )
        //{
        //    animator.SetBool( "apper" , true );
        //}
        //if( Input.GetKeyUp( KeyCode.Space ) )
        //{
        //    animator.SetBool( "apper" , false );
        //}
        distance = transform.position.z - cameraTransform.transform.position.z;
        distance = Mathf.Abs( distance );
        if( distance < targetDistance )
        {
            animator.SetBool( "apper" , true );
        }
        if (cameraTransform.position.z < transform.position.z)
        {
            //gameObject.SetActive(false);
            //Destroy(gameObject);
        }
    }

    void OnCollisionEnter( Collision other )
    {
        //Debug.Log( "あたり！" );
		SoundManager.PlaySe("GameSE_Break");

		if ( other.gameObject.CompareTag( "Player" ) )
        {
			//GameManager.SetMode(GameManager.Mode.RESULT);
            //Destroy(other.gameObject);
		}
    }
}
