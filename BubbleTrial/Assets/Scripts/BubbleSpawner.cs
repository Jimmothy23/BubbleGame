using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{
    public GameObject[] bubblePrefabs;
    public Transform[] spawnPoints;

    //Delay times for Bubble Spawns
    public float minDelay = 0.1f;
    public float maxDelay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBubbles());
        
    }

   IEnumerator SpawnBubbles ()
    {
        while (true)
        {
            //spawn bubbles

            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(2f);

            int spawnIndex = Random.Range(0, spawnPoints.Length);
            int bubbleIndex = Random.Range(0, bubblePrefabs.Length);
            GameObject bubblePrefab = bubblePrefabs[bubbleIndex];
            Transform spawnPoint = spawnPoints[spawnIndex];

            Instantiate(bubblePrefab, spawnPoint.position, spawnPoint.rotation);
            
        }
    }
}
