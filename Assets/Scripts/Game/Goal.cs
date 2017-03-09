using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour
{
    GameObject obj;
    void OnTriggerEnter(Collider target)
    {
        if (target.tag != "Player") return;

        ClearUI Clear;
        obj = GameObject.Find("GameUI");
        Clear = obj.GetComponent<ClearUI>();
        Clear.SpawnClearUI();

        // 状態変更
        //GameManager.SetMode(GameManager.Mode.RESULT);
        Destroy(target.gameObject);
    }
}
