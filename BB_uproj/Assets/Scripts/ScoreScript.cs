
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    [SerializeField] private TextMeshPro score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {

        score.text = scoreValue.ToString();
        
    }
}
