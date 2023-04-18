using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class colliderControll : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    if(collider.tag == "Car")
        {
            int index = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(index);
        }
}
