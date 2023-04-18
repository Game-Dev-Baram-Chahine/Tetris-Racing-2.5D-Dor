using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelSelect : MonoBehaviour
{
    Dropdown drop;
    public static int level;
    // Start is called before the first frame update
    void Start()
    {
        drop = GetComponent<Dropdown>();
        //drop.ClearOptions();
        //level = 1;
    }

    void Update()
    {
        //Debug.Log(drop.value);
        level = drop.value;
    }
    public void HandleInputData()
    {
        drop = GetComponent<Dropdown>();
        Debug.Log("changed");
        level = drop.value;
    }

}
