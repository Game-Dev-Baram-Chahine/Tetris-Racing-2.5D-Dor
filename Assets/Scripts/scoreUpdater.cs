using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreUpdater : MonoBehaviour
{

    public Text textSc;
    public int sc;
    // Start is called before the first frame update
    void Start()
    {
        sc = Score.GetScore();
        textSc.text = "Score: " + sc.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        sc = Score.GetScore();
        textSc.text = "Score: " + sc.ToString();
    }
}
