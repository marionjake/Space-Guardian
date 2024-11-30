using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class PointManager : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE: " + score;
    }

    public void updateScore(int points)
    {
        score += points;
        scoreText.text = "SCORE: " + score; 
    }
}
