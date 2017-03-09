using UnityEngine;
using System.Collections;

public class FlowTile : MonoBehaviour {

    Transform cameraTransform;
    private bool flowFlag;
    private float gravity;
    // Use this for initialization
    void Start () {
        flowFlag = false;
        gravity = 0.98f/2;
        cameraTransform = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update() {
       if(cameraTransform.position.z < transform.position.z )
        {
            gameObject.SetActive(false);
            //Destroy(gameObject);
            //GetComponent<MeshRenderer>().enabled = false;
        }
       if(flowFlag)
        {
            Vector3 pos = transform.position;
            pos.y -= gravity;
            transform.position = pos;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Flow");
        if (col.gameObject.CompareTag("Player"))
        {
            //   GetComponent<Rigidbody>().useGravity = true;
            flowFlag = true;
        }
    }

}
