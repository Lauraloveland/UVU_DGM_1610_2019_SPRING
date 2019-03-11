using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoremanager : MonoBehaviour
{
    public static int score;
    Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
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
}
