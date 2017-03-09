using UnityEngine;
using System.Collections;

public class HunmerMotion : MonoBehaviour {

    public Animator anim;
    public int motionCnt;
    // Use this for initialization
    void Start()
    {
        motionCnt = 0;
     //z   anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            motionCnt++;
            if (motionCnt >= 6)
            {
                motionCnt = 2;
            }
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            motionCnt = 0;
        }


        anim.SetInteger("swing", motionCnt);
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
