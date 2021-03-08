using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class SpawnItem : MonoBehaviour
{
    public Item[] items;
    GameObject currentItem;
    public Transform[] spawnPoint;
    int currentPoint = 0;

    public string ConfFileName = "ConfigData.csv";
    Dictionary<string, ItemClass> itemClasses = new Dictionary<string, ItemClass>();

    private void Awake() {
        ReadData();
    }
    private void ReadData()
    {
        StreamReader input = null;
        string path = "Assets/StreamingAssets";
        try
        {
            input = File.OpenText(Path.Combine(path,
                                        ConfFileName));
            string name = input.ReadLine();
            string values = input.ReadLine();
            while (values != null)
            {
                AssignData(values);
                values = input.ReadLine();
            }
        }
        catch (Exception ex) { Debug.Log(ex.Message); }
        finally { if (input != null) input.Close(); }
    }
    void AssignData(string values)
        {
            string[] data = values.Split(',');
            float no = int.Parse(data[0]);
            string itemName = data[1];
            int speed = int.Parse(data[2]);
            int score = int.Parse(data[3]);
            int loopSpawn = int.Parse(data[4]);
            string showText = data[5];
            ItemClass itemClass = new ItemClass(score, speed,loopSpawn,showText);
            itemClasses.Add(itemName, itemClass);
        }

    private void Start() {
        spawnNewItem();
    }

    private void Update() {
        currentItem = GameObject.FindGameObjectWithTag("Item");

        if(currentItem == null){
            spawnNewItem();
        }
    }

    public void spawnNewItem(){
        int randomItem = UnityEngine.Random.Range(0,items.Length);
        int randomSpawnPoint = UnityEngine.Random.Range(0,spawnPoint.Length);

        

        if(randomSpawnPoint == currentPoint){
            spawnNewItem();
            
        }else{
            string className = items[randomItem].GetType().Name;
            int speed = 1;
            int score = 1;
            int loopspawn = 1;
            string showText = "";
            ItemClass itemData = new ItemClass(score,speed,loopspawn,showText);
            switch(className){
                case "GreenItem" :
                    itemData = itemClasses["GreenItem"];
                    break;
                case "YellowItem" :
                    itemData = itemClasses["YellowItem"];
                    break;
                case "PinkItem" :
                    itemData = itemClasses["PinkItem"];
                    break;
                case "BlackItem" :
                    itemData = itemClasses["BlackItem"];
                    break;
            }

            items[randomItem].speed = itemData.Speed;
            items[randomItem].getScore = itemData.Score;
            items[randomItem].LoopSpawn = itemData.LoopSpawn;
            items[randomItem].showText = itemData.ShowText;


            Instantiate(items[randomItem],spawnPoint[randomSpawnPoint].position,Quaternion.identity);
            currentPoint = randomSpawnPoint;
        }
    }
}
