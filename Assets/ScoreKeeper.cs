
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Controllers/ScoreKeeper")]
public class ScoreKeeper : ScriptableObject
{
    public int CurrentScore = 0;
    public int HighScore = 0;

    private void OnEnable()
    {
        CurrentScore = 0;
    }

    public void IncrementScore()
    {
        CurrentScore++;
        if (CurrentScore > HighScore)
        {
            HighScore = CurrentScore;
        }
    }



}
