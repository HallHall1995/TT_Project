using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AdvanceRation : MonoBehaviour {

    public Transform StartPoint;        // 計測開始地点
    public Transform EndPoint;          // 計測終了地点
    public Transform TargetPos;         // 目標
    public Text AdvanceRationText;      // パーセンゲージUI
    private float fAdvanceRationNum;    // パーセンゲージfloat
    private int AdvanceRationNum;       // パーセントint
    private float distance;             // 開始地点から終了地点の距離

    void Start ()
    {
        distance = StartPoint.position.z - EndPoint.position.z;
        fAdvanceRationNum = 0;
    }
	
	void Update()
    {
        if (TargetPos == null) return;
        float distanceTarget = StartPoint.position.z - TargetPos.position.z;
        AdvanceRationNum = ( int ) fAdvanceRationNum;
        fAdvanceRationNum = (distanceTarget / distance) * 100;
        //Debug.Log(fAdvanceRationNum);
        AdvanceRationText.text = AdvanceRationNum.ToString() + "%";
    }

    // フィールドの進行率を渡す関数(int型)
    public int GetAdvanceRation()
    {
        return AdvanceRationNum;
    }
}
