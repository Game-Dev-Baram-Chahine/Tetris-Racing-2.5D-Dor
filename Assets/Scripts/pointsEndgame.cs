using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointsEndgame : MonoBehaviour
{
    public Text finalScoreText;
    public int finalScore;

    // Start is called before the first frame update
    void Start()
    {
        finalScore = Score.GetScore();
        finalScoreText.text = "Final Score: " + finalScore.ToString();
    }

}
