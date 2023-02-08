using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public static ScoreText instance;

    public TMP_Text myScoreText;
    public int scoreNumber = 0;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
        myScoreText.text = "Monnezza: " + scoreNumber.ToString();

    }

    public void IncreaseScore(int v)
    {
        scoreNumber += v;
        myScoreText.text = "Monnezza: " + scoreNumber.ToString();
    }

}
