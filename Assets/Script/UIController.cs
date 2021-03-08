using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public PlayerController player;
    public Text scoreText;
    public Text ShowText;
    private void Update() {
        scoreText.text = "Score : " + PlayerPrefs.GetInt("Score");
    }

    public void ResetScore(){
        PlayerPrefs.DeleteAll();
    }

    
}
