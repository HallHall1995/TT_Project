using UnityEngine;
using System.Collections;

public class Dead : MonoBehaviour {

    public GameObject Level1Player;
    public GameObject StartPoint;
    public GameObject PlayerLife;

    private void Start()
    {
        SoundManager.LoadSe("Respawn", "_n_death_music");
    }

    void OnTriggerEnter(Collider target)
    {
        //if (target.tag != "Player") return;

        // 状態変更

        if(target.tag == "Player")
        {
            Destroy(target.gameObject);

            PlayerLifeManager Plm = PlayerLife.GetComponent<PlayerLifeManager>();
            GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            gameManager.LEVEL = 0;
            int life = Plm.DamageReturnInt();
            if (life <= 0)
            {
                GameManager.bGameover = true;
                return;
            }

            Vector3 pos = new Vector3(StartPoint.transform.position.x, 5.085f, StartPoint.transform.position.z);
            GameObject Player = Instantiate(Level1Player, pos, Quaternion.identity);

            SoundManager.PlaySe("Respawn");

            Player.transform.parent = null;
            player.bDead = true;
            
        }
    }
}
