using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearUI : MonoBehaviour
{

    public Text ClearTxt;
    private bool Finish;

    public GameObject ResultMenuUI;
	void Start ()
    {
        SoundManager.LoadBgm("Clear", "_n_clear_music");
        ClearTxt.text = "";
        Finish = false;
    }

    void Update()
    {
        if (Finish)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SoundManager.StopBgm();
                Fader.instance.BlackOut(1.5f,"Title");
            }
        }
    }

    public void SpawnClearUI()
    {
        SoundManager.StopBgm();
        SoundManager.PlayBgm("Clear");
        Finish = true;

        string str = "GAME CLEAR";
        ClearTxt.text = str;

        ResultMenuUI.SetActive(true);
    }
}
