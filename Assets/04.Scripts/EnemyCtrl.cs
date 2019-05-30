using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour {
    public int hp = 5;
    public int initHp = 5;

    public Transform tr;
    public GameObject effect;

    void OnTriggerEnter2D(Collider2D coll) {
        if (coll.CompareTag("PLAYER")) {
            Debug.Log("Touch!");
            hp--;
            if(hp == 0) {
                GameManager.score += 100;
                Debug.Log(GameManager.score);
                Instantiate(effect, tr.position, Quaternion.identity);
                Destroy(this.gameObject);
            }
        }

        if (coll.CompareTag("DESTROYER")){
            Destroy(this.gameObject);
        }

    }
    
       
}
