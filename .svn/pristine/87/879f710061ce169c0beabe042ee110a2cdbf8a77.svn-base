using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour {

    static public bool bPause;
    public GameObject Pause;

	// Use this for initialization
	void Start () {
        bPause = false;
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            bPause = true;
            Pause.SetActive(!Pause.active);
        }
	}
}
