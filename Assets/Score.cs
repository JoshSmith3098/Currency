using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
    public GUIText scoreText;
    private int GearValues;
    void Start()
    {
        var myGlobalArray = Currency.Instance.GlobalArray; ;
        UpdateScore();

    }
    public void AddScore(int newScoreValue)
    {
        GearValues += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + GearValues;
    }
}