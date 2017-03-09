using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour {

    bool isUsed;

	void Start ()
    {
        isUsed = false;
        Fader.instance.BlackIn();
        SoundManager.LoadBgm("TitleBGM", "Cry_Of_Night");
        SoundManager.PlayBgm("TitleBGM");

		SoundManager.LoadSe("Decision", "Decide");
		SoundManager.LoadSe("Decision2", "gool_swish");
	}

	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Fader.instance.BlackOut(1.5f,"Game");
        }
    }

    public void NextScene()
    {
        if (isUsed) return;
        isUsed = true;
        //シーン遷移
        SoundManager.PlaySe("Decision");
		SoundManager.PlaySe("Decision2");
		Fader.instance.BlackOut(1.5f);
        StartCoroutine(DelayMethod(1.5f, "Game"));
    }

    // ----------------------------------------------------------------------
    // [ Delay(Sleep:処理をわざと遅らせる)処理 ]
    // ----------------------------------------------------------------------
    private IEnumerator DelayMethod(float waitTime, string Scene)
    {
        yield return new WaitForSeconds(waitTime);  // waitTime後に実行する
        SoundManager.StopBgm();
        SceneManager.LoadScene(Scene.ToString());   // シーン切り替え
    }
}
