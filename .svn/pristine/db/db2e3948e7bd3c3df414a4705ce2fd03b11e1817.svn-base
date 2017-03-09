using UnityEngine;
using System.Collections;

public class ObjDestroy : MonoBehaviour {

	public int Cnt;
	public int Time;
	// Use this for initialization
	void Start () {
		Cnt = 0;
		Time = 60;
	}

	// Update is called once per frame
	void Update () {
		Cnt ++;
		if (Cnt > Time) {
			Cnt = 0;
			Destroy (this.gameObject);
		}
	}
}