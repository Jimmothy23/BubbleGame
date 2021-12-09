using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{
    /*This script contains the spawn points and bubble prefabs and is responsible for randomizing their locations, types and spawning them*/


    public GameObject[] bubblePrefabs;          //Public variable that allows for addition of the bubble prefabs in the Unity Editor
    public Transform[] spawnPoints;             //Public variaible that allows for addition of the spawn points in the Unity Editor

    //Delay times for Bubble Spawns
    public float minDelay = 0.1f;
    public float maxDelay = 1f;

    
    void Start()
    {
        StartCoroutine(SpawnBubbles());
        
    }

   IEnumerator SpawnBubbles ()
    {
        while (true)
        {
            //spawn bubbles

            float delay = Random.Range(minDelay, maxDelay);             //Variable for the delay time between when bubbles spawn)
            yield return new WaitForSeconds(2f);

            int spawnIndex = Random.Range(0, spawnPoints.Length);       //Variable that randomizes which spawn point the bubbles will appear at.
            int bubbleIndex = Random.Range(0, bubblePrefabs.Length);    //Variable that randomizes which bubble spawn. 
            GameObject bubblePrefab = bubblePrefabs[bubbleIndex];   
            Transform spawnPoint = spawnPoints[spawnIndex];

            Instantiate(bubblePrefab, spawnPoint.position, spawnPoint.rotation);        //Adds the randomized bubble at the randomized spawn point.
            
        }
    }
}
