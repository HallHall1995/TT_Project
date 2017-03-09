using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUpSystem : MonoBehaviour {
    public GameObject[] nextPlayer;
    public GameObject particle;
    public float force = 800f;
    private float time = 0f;
    private bool once = false;
	// Use this for initialization
	void Start () {
        SoundManager.LoadSe("LevelUp", "_n_lv_up_music");
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
    }

    void OnTriggerEnter(Collider col)
    {
        // アイテムを取得
        if (col.gameObject.tag == "LevelUpItem" && !once)
        {
            SoundManager.PlaySe("LevelUp");
            once = true;
            GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            gameManager.LEVEL += 1;
            int level = gameManager.LEVEL;
            if(level >= 9)
            {
                gameManager.LEVEL -= 1;
            }
            else
            {
                Instantiate(nextPlayer[level], this.transform.position, Quaternion.identity);
                GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().AddForce(Vector3.up * force, ForceMode.VelocityChange);
                Destroy(col.gameObject);
                Instantiate(particle, this.transform.position, Quaternion.identity);
                Destroy(this.gameObject);
            }
        }
        // アイテムを取得
        if (col.gameObject.tag == "gimmick" && time >= 3.0f)
        {
            Debug.Log("あたり");
            time = 0;
            GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            gameManager.LEVEL -= 1;
            int level = gameManager.LEVEL;
            if (level <= -1)
            {
                gameManager.LEVEL += 1;
            }
            else
            {
                Instantiate(nextPlayer[level], this.transform.position, Quaternion.identity);
                Instantiate(particle, this.transform.position, Quaternion.identity);
                GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().AddForce(Vector3.up * force);
                Destroy(this.gameObject);
            }
        }
    }
}
