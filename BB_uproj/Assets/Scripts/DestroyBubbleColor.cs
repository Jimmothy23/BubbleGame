using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DestroyBubbleColor : MonoBehaviour
{
    /*This script contains the elements to control the destruction of the bubbles in the color specific game mode
     I am looking to make changes to it and combine it with the DestroyBubble script in the future.
         */
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    [Header("Unity Setup")]



    [SerializeField] private Transform textColor;       //Private field to add the text colors in and allows for addition of other colors

    [SerializeField] private Rigidbody2D rb;

   
    public ParticleSystem deathParticles;

   

    void OnMouseDown()                                  //Event that leads to the action when the bubble is activated.
    {
        ScoreScript.scoreValue += 1;
        Instantiate(deathParticles, transform.position, Quaternion.identity);       //Adds the particle effects to the environment
        Instantiate(textColor, transform.position, Quaternion.identity);            //Adds the text to the environment
        Destroy(gameObject);

        

    }
}
