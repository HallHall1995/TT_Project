using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

    private bool view;
    public GameObject PauesMenu;
    public float ContinueTime;  // ポーズ画面を閉じてからゲームを再開するまでの時間

	void Start ()
    {
        view = false;
        PauesMenu.SetActive(false);
		SoundManager.LoadSe("Decision", "Decide");

	}

	public void PauseButton()
    {
        if (view)
        {
			// 状態変更
			SoundManager.PlaySe("Decision");
			GameManager.SetMode(GameManager.Mode.GAME);
            PauesMenu.SetActive(false);
        }
        else
        {
			// 状態変更
			SoundManager.PlaySe("Decision");
			GameManager.SetMode(GameManager.Mode.PAUSE);
            PauesMenu.SetActive(true);
        }
        view = !view;
    }

	public void PlayGame()
	{
		SoundManager.PlaySe("Decision");
		if (view)
		{
			// 状態変更
			GameManager.SetMode(GameManager.Mode.GAME);
			PauesMenu.SetActive(false);
		}
	}
}
