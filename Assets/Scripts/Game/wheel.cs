using UnityEngine;
using System.Collections;

public class wheel : MonoBehaviour {

    public Animator anim;
    public float move;          //  移動量
    public float moveWidth;     //  移動幅
    public float activeLength;  //  起動するタイミング

    Transform cameraTransform;

    private bool active;
    private Vector3 pos;
    private bool moveLeft;

    public SkinnedMeshRenderer render;
	// Use this for initialization
	void Start () {
        pos = GetComponent<Transform>().position;
        moveLeft = true;
        active = false;
        cameraTransform = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update() {

        if( active )
        {
            if( moveLeft )
            {
                pos += new Vector3(move * Time.deltaTime, 0, 0 );
                if( pos.x > moveWidth )
                    moveLeft = false;
            }
            else
            {
                pos -= new Vector3(move * Time.deltaTime, 0, 0 );
                if( pos.x < -moveWidth )
                    moveLeft = true;
            }
        }
        else
        {
            Vector3 caPos = cameraTransform.position;
            Vector3 whPos = pos;

            caPos.y = 0;
            whPos.y = 0;

            if( ( caPos - whPos ).magnitude < activeLength )
            {
                active = true;
            }
        }

        if( pos.z > cameraTransform.position.z )
        {
            //  GetComponent<SkinnedMeshRenderer>().enabled = false;
            gameObject.SetActive(false);
            //Destroy(gameObject);
            //render.enabled = false;
        }

        transform.position = pos;
            
        anim.SetBool( "active", active );
        anim.SetBool( "moveLeft", moveLeft );
	}
    void OnCollisionEnter( Collision other )
    {
        Debug.Log( "あたり！" );
		SoundManager.PlaySe("GameSE_Break");
		if ( other.gameObject.CompareTag( "Player" ) )
        {
			//GameManager.SetMode( GameManager.Mode.RESULT);
            //Destroy(other.gameObject);
        }
    }
}
