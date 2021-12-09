using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoundary : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)             //Simple script to destroy the bubbles once the reach the edge of the screen boundary. 
    {
        Destroy(collision.gameObject);
    }
}
