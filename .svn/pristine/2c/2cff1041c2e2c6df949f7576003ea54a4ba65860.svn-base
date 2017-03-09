using UnityEngine;
using System.Collections;

public class playerFollow : MonoBehaviour {

   // public Transform target;
    public Vector3 offset;
    public GameObject player;
	
	void Update ()
    {
        //if (target == null) return;
        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        else
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y + offset.y, player.transform.position.z + offset.z);
        }
        //var player = GameObject.FindGameObjectWithTag("Player");
	}
}
