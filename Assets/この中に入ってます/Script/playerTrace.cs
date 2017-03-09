using UnityEngine;
using System.Collections;

public class playerTrace : MonoBehaviour {

	public Transform target;
	public Vector3 offset;
	public int timeCnt;
	public int lifeTime;
	public GameObject traceEffect;
	private bool clickOn; 

	// Use this for initialization
	void Start () {
		GetComponent<Transform>().position = target.position + offset;
		clickOn = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			clickOn = true;
		}

		if (clickOn) {
			timeCnt--;
			if (timeCnt <= 0) {
				timeCnt = lifeTime;
				GetComponent<Transform> ().position = target.position + offset;
				Instantiate (traceEffect, transform.position, Random.rotation);
			}
		}
	}
}
