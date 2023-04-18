using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gameRestart : MonoBehaviour
{

    public void restartGame(int howFar)
    {
        Score.ScoreReset();
        int index = SceneManager.GetActiveScene().buildIndex - howFar;
        SceneManager.LoadScene(index);
    }
}
