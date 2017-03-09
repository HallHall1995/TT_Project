using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLifeManager : MonoBehaviour {

    public Text life;
    public int InitLife;
    private int NowLife;
    bool bResult;

	// Use this for initialization
	void Start () {
        NowLife = InitLife;
        bResult = false;
    }
	
	// Update is called once per frame
	void Update () {
        string str = "X "+NowLife.ToString();
        life.text = str;

        if(Input.GetKeyDown(KeyCode.F))
        {
            Damage();
        }

        if (NowLife <= 0 && !bResult)
        {
            bResult = true;
            GameManager.SetMode(GameManager.Mode.RESULT);
        }

        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    Damage();
        //}
    }

    public void Damage()
    {
        NowLife--;
    }

    public int DamageReturnInt()
    {
        NowLife--;

        return NowLife;
    }
}
