using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenItem : Item
{
    
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            Destroy(this.gameObject);
            other.GetComponent<PlayerController>().CurrentScore += getScore;
            other.GetComponent<PlayerController>().speed += speed;

            
            showtextObject.text = showText;
            

            PlayerPrefs.SetInt("Score",other.GetComponent<PlayerController>().CurrentScore);
            PlayerPrefs.Save();
        }
    }
}
