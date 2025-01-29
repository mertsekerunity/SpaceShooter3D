using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    int score;
    TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = FindObjectOfType<TMP_Text>();
        scoreText.text = "Score: 0";
    }

    public void IncreaseScore(int amountToIncrease)
    {
        score += amountToIncrease;
        scoreText.text = "Score: " + score.ToString();
        Debug.Log("Score: " + score);
    }
}
