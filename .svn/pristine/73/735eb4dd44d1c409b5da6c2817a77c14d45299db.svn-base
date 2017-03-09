using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashTitle : MonoBehaviour {

    private Text image;
    public float FlashPower;

	// Use this for initialization
	void Start () {
        image = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        float alpha = image.color.a;
        alpha -= FlashPower;
        Debug.Log("alpha = "+alpha);
        image.color = new Color(image.color.r, image.color.g, image.color.b, alpha);

        if(alpha <= 0.0f || alpha >= 1.0f)
        {
            FlashPower *= -1;
        }
	}
}
