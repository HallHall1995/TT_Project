using UnityEngine;
using System.Collections;

public class JumpTile : MonoBehaviour {

    //Rigidbody playerRig;
    //public float jump;
    Transform cameraTransform;

    void Start ()
    {
        //playerRig = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
        cameraTransform = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();
        SoundManager.LoadSe("Jump", "status-up2");
	}

	void Update()
    {
        //if (playerRig == null) return;
        if( cameraTransform.position.z < transform.position.z )
        {
            //gameObject.SetActive(false);
            //Destroy(gameObject);
        }
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
			SoundManager.PlaySe("Jump");
            col.gameObject.GetComponent<player>().SetAccelerate();
            //playerRig.AddForce( transform.up * jump );
        }
    }
}
