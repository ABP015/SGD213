using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text winText;
    private float totalScore;

    private void Start()
    {
        winText.text = "";
    }

    // Function to update UI text
   public void UpdateScoreboard()
    {
        totalScore = totalScore + 1;
        scoreText.text = "Count: " + totalScore.ToString();
        if (totalScore >= 12)
        {
            // Set the text value of our 'winText'
            winText.text = "You Win!";
        }
    }
}
