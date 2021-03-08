public class ItemClass
{
    public string name;
    int score = 0;
    int speed = 0;
    int Loopspawn = 0;
    string showText = "";

    public ItemClass(int newScore,int newSpeed, int newLoopSpawn, string newShowText){
        score = newScore;
        speed = newSpeed;
        Loopspawn = newLoopSpawn;
        showText = newShowText;
    }

    public int Speed{
        get{
            return speed;
        }
    }
    public int Score{
        get{
            return score;
        }
    }
    public int LoopSpawn{
        get{
            return Loopspawn;
        }
    }
    public string ShowText{
        get{
            return showText;
        }
    }

}
