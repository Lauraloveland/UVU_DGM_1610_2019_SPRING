using UnityEngine.UI;
using UnityEngine;

public class Scoremanager : MonoBehaviour
{
    public static int score;
    private Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
      
    //Gets UI text component
        ScoreText = GetComponent<Text>();
        score = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(score<0)
        score=0;

        ScoreText.text = " " + score;
    }
    public static void AddPoints(int pointsToAdd);{

    
        score += pointsToAdd;

    }

