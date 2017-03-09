using UnityEngine;
using System.Collections;

public class TitleCameraMove : MonoBehaviour {

    public Transform StartPont;
    public Transform TargetPoint;
    public float MoveTime;      // 目標へ移動する時間
    private bool start;
    private Vector3 Move;
    private Vector3 Angle;


    void Start ()
    {
        Move = TargetPoint.position - StartPont.position;
        Debug.Log("Base : "+ Move);
        Move = (Move / MoveTime) / 60;
        Debug.Log("Frame" + Move);

        //Angle = TargetPoint.localEulerAngles - StartPont.localEulerAngles;
        //Angle = (Angle / MoveTime) / 60;
        start = false;
    }
	
	void Update ()
    {
        if (!start) return;
        if (MoveTime < 0.0f) return;
        MoveTime -= (1.0f * Time.deltaTime);
        transform.position += Move;
    }

    public void Begin()
    {
        start = true;
    }
}
