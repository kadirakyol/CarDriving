using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{

    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float scoreMultiplier;

    private float score;
    private int currentHighScore;

    public const string HighScorekey = "HighScore";

    void Update()
    {
        score += Time.deltaTime * scoreMultiplier;
        scoreText.text = Mathf.FloorToInt(score).ToString();
    }

    private void OnDestroy()
    {
        currentHighScore = PlayerPrefs.GetInt(HighScorekey,0);
        if (score > currentHighScore)
        {
            PlayerPrefs.SetInt(HighScorekey, Mathf.FloorToInt(score));
            
        }

    }
    
}
