using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    private double score = 0;
    public double howMuchToAdd = 0.5;
    public float updateDelay = 2f; // Delay in seconds before updating score text

    void Awake()
    {
        // Ensure there's only one ScoreManager instance
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddPoint()
    {
        score += howMuchToAdd;
        StartCoroutine(UpdateScoreText());
    }

    IEnumerator UpdateScoreText()
    {
        yield return new WaitForSeconds(updateDelay);
        scoreText.text = "" + score;
    }
}
