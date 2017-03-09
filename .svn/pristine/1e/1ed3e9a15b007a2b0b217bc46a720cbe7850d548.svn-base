using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUpParticle : MonoBehaviour {
    private float time = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if(time >= 0.75f)
        {
            Destroy(this.gameObject);
        }
	}
}
