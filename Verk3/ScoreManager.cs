
/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    private TextMeshProUGUI countText;

    public TextMeshProUGUI scoreText;

    int score = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = " SCORE: " + score.ToString();
    }


    public void AddPoint()
    {
        score += 1;
        scoreText.text = " SCORE: " + score.ToString();
    }
}
*/