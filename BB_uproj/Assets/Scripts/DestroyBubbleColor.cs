using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DestroyBubbleColor : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    [Header("Unity Setup")]



    [SerializeField] private Transform textColor;

    [SerializeField] private Rigidbody2D rb;

   
    public ParticleSystem deathParticles;

   

    void OnMouseDown()
    {
        ScoreScript.scoreValue += 1;
        Instantiate(deathParticles, transform.position, Quaternion.identity);
        Instantiate(textColor, transform.position, Quaternion.identity);
        Destroy(gameObject);

        

    }
}
