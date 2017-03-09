using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultMenuUIManager : MonoBehaviour {

    public Text[] Menu;
    private int id;

	// Use this for initialization
	void Start () {
        id = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.W))
        {
            id++;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            id--;
        }
        int size = Menu.Length;
        if(id >= size)
        {
            id = 0;
        }

        if(id < 0)
        {
            id = size-1;
        }
    }
}
