using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public int getScore = 0;
    public int speed = 0;
    public int LoopSpawn = 0;
    public string showText = "";
    public Text showtextObject;

    public float speedRotation = 10f;
    
    
    private void Update() {
        showtextObject = GameObject.FindGameObjectWithTag("ShowText").GetComponent<Text>();
        RotateObject();
    }

    void RotateObject(){
        transform.Rotate(0,0,speedRotation * Time.deltaTime);
    }
}
