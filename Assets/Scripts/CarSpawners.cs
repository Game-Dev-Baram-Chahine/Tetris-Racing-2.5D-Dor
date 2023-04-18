using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawners : MonoBehaviour
{
    [SerializeField] GameObject carPrefab; // The car prefab to spawn
    [SerializeField] float spawnInterval = 2.0f; // The interval between spawns
    [SerializeField] float carSpeed = 5.0f; // The speed at which the cars move to the right
    [SerializeField] Vector3[] spawnPoints; // The three spawn points for the cars

    [SerializeField] float timer = 0.0f; // The timer for spawning cars

    void Update()
    {
        // Increment the timer
        timer += Time.deltaTime;

        // If the timer has reached the spawn interval, spawn a car and reset the timer
        if (timer >= spawnInterval)
        {
            SpawnCar();
            timer = 0.0f;// + (levelSelect.level * 0.5f);
        }
    }

    void SpawnCar()
    {
        // Choose a random spawn point
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        Vector3 spawnPoint = spawnPoints[spawnIndex];



        // Instantiate a new car at the spawn point
        GameObject car = Instantiate(carPrefab, spawnPoint, Quaternion.Euler(0.0f, -90.0f, 90.0f));


        // Set the speed of the car to the specified speed
        CarMover carMover = car.GetComponent<CarMover>();
        carMover.speed = carSpeed + (5.0f*levelSelect.level);
    }
}
