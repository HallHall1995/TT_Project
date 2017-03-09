using UnityEngine;
using System.Collections;

public class HunmerCol : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("あたり！");
		SoundManager.PlaySe("GameSE_Break");
		if (col.gameObject.CompareTag("Player"))
        {
			GameManager.SetMode( GameManager.Mode.RESULT);
        }
    }
}
