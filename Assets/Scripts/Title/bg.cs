using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class bg : MonoBehaviour {

    public Image ImageObj;
    public Image ButtonObj;
    public float AlphaTime;  // 透明になるまでの時間
    private float TimeCnt;
    private bool start;
    private bool end;

	// Use this for initialization
	void Start () {
        start = false;
        end = false;
        TimeCnt = AlphaTime;
        //Begin();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (end) return;
        if (!start) return;
        TimeCnt -= (1.0f * Time.deltaTime);
        ImageObj.color = new Color(1.0f, 1.0f, 1.0f, (TimeCnt / AlphaTime) * 1.0f);
        ButtonObj.color = new Color(1.0f, 1.0f, 1.0f, (TimeCnt / AlphaTime) * 1.0f);
        //ButtonObj.rectTransform.sizeDelta = new Vector2(ButtonObj.rectTransform.);
        if (TimeCnt > 0.0f) return;
        end = true;
    }

    public void Begin()
    {
        start = true;
    }
}
