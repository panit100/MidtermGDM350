using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkItem : Item
{
    public SpawnItem spawnItem;

    private void Start() {
        spawnItem = GameObject.FindObjectOfType<SpawnItem>();
    }
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            Destroy(this.gameObject);
            other.GetComponent<PlayerController>().CurrentScore += getScore;
            for(int i = 0; i < LoopSpawn; i++){
                spawnItem.spawnNewItem();
            }

            showtextObject.text = showText;

            
            PlayerPrefs.SetInt("Score",other.GetComponent<PlayerController>().CurrentScore);
            PlayerPrefs.Save();
        }
    }
}
