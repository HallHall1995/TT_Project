using UnityEngine;
using System.Collections;

public class bunchin : MonoBehaviour {

    public Animator anim;
    public float flyingPos;     //  飛んでる高さ
    public float move;          //  移動量

    Transform cameraTransform;

    public float activeLength;  //  起動するタイミング
    public float dropLength;    //  落ちてくるタイミング( プレイヤーとの水平距離 )

    private Vector3 pos;
    private bool flyDrop;

    private bool active;

	// Use this for initialization
	void Start () {
        flyDrop = true;
        pos = GetComponent<Transform>().position;
        active = false;
        cameraTransform = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 plPos = cameraTransform.position;
        Vector3 bunPos = pos;
        plPos.y = 0;
        bunPos.y = 0;

        if( ( plPos - bunPos ).magnitude < activeLength )
        {
            active = true;
        }

        if( active )
        {
            if( ( plPos - bunPos ).magnitude < dropLength )
            {
                flyDrop = false;
            }

            if( flyDrop )
            {
                pos += new Vector3( 0, move, 0 );
                if( flyingPos < pos.y && move > 0 )
                    pos.y = flyingPos;
            }
            else
            {
                pos.y -= 0.35f;
            }

            if( pos.y < 0 )
            {
                pos.y = 0;
            }
            transform.position = pos;
        }
        anim.SetBool( "Active", active );
        anim.SetBool( "FlyDrop", flyDrop );
        if (cameraTransform.position.z < transform.position.z)
        {
            gameObject.SetActive(false);
            //Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision other)
    {
        Debug.Log( "あたり！" );
		SoundManager.PlaySe("GameSE_Break");
		if ( other.gameObject.CompareTag( "Player" ) )
        {
			//GameManager.SetMode( GameManager.Mode.RESULT);
           // Destroy(other.gameObject);
        }
    }
}
