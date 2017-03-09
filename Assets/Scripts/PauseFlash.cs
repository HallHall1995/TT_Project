using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseFlash : MonoBehaviour {

    public Text[] text;
    static private int SelectId;
    private bool bApp;
    private float CntApp;
    public float BaseApp;

	// Use this for initialization
	void Start () {
        SelectId = 0;
        bApp = true;
        CntApp = 0;
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Color color = text[SelectId].color;
            text[SelectId].color = new Color(color.r, color.g, color.b,1.0f);
            SelectId++;
        }

        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Color color = text[SelectId].color;
            text[SelectId].color = new Color(color.r, color.g, color.b, 1.0f);
            SelectId--;
        }

        //ここにフェード関係の処理を入れる
        //if～
        //switch (SelectId)
        //{
        //    case 0://そのまま戻る
        //        PauseManager.bPause = false;
        //        return;
        //    case 1://最初から
        //        break;
        //    case 2://タイトルへ
        //        break;
        //    default://ここには入らない
        //        break;
        //}

        if(SelectId < 0)
        {
            SelectId = 2;
        }

        if(SelectId > 2)
        {
            SelectId = 0;
        }

        Color col = text[SelectId].color;
        CntApp += Time.deltaTime;

        if(BaseApp <= CntApp)
        {
            CntApp = 0;
            bApp = !bApp;
        }

        if (bApp)
        {
            text[SelectId].color = new Color(col.r, col.g, col.b, 1.0f);
        }

        else
        {
            text[SelectId].color = new Color(col.r, col.g, col.b, 0.0f);
        }
    }
}
