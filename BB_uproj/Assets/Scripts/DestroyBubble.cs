using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DestroyBubble : MonoBehaviour
{
    /*This script contains the elements that destory the bubble when it is touched. I separated it into two separate units, 
     * I did this because at the time of programming I was struggling to figure out a way to only add the counter when a counting mode bubble was destroyed. I am going to consolitdate*/
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();           
        
    }

    [Header("Unity Setup")]  

    [SerializeField] private Transform textScore;   //Variable for the texScore 

    [SerializeField] private Rigidbody2D rb;      

    public ParticleSystem deathParticles;

   

    void OnMouseDown()
    {
        ScoreScript.scoreValue += 1;                                                    //Adds to the score value of a counting mode bubble when it is destroyed.
        Instantiate(deathParticles, transform.position, Quaternion.identity);           //Adds the particle elements to the scene at the point of destruction.
        Instantiate(textScore, transform.position, Quaternion.identity);                //Adds the text score to the scene at the point of destruction.
        //Instantiate(textColor, transform.position, Quaternion.identity);
        Destroy(gameObject);                                                            //Destroys the game object.

        

    }
}
