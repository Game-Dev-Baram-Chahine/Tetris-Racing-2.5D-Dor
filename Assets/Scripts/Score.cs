using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    static int score;
    public static int pointsForCar = 100;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        
    }

    public static int AddScore(int toAdd)
    {
        toAdd = toAdd * (levelSelect.level + 1);
        Debug.Log(levelSelect.level);
        score += toAdd; 
        //Debug.Log(score);
        return score;
       
    }

    public static int GetScore()
    {
        return score;
    }

    public static int ScoreReset()
    {
        int tmp = score;
        score = 0;
        return tmp;
    }
}
