using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text timer;
    public int InitTime;
    private int NowTime;
    private int fps;
    private float CntTimer;
    public int DangerTime;
    private string DangerTimeKey;

	// Use this for initialization
	void Start () {
        NowTime = InitTime;
        fps = 1;
        CntTimer = 0;
        DangerTimeKey = "DangerTime";
        SoundManager.LoadSe(DangerTimeKey, "crash_glass_crash-001");
    }
	
	// Update is called once per frame
	void Update () {
        if(NowTime <= 0)
        {
            //リザルト表示
            GameManager.SetMode(GameManager.Mode.RESULT);
            return;
        }

        CntTimer += Time.deltaTime;
        if(CntTimer >= fps)
        {
            if(NowTime < DangerTime)
            {
                SoundManager.PlaySe(DangerTimeKey);
            }

            NowTime--;
            CntTimer = 0;
        }

        timer.text = NowTime.ToString();

    }

    public void Restart()
    {
        NowTime = InitTime;
        CntTimer = 0;
    }
}
