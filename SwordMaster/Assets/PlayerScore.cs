using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour {

    public string[] ranks;
    public int[] scoreNeededForRank;

    int currentScore = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public int GetHighScore(){
        return PlayerPrefs.GetInt("High Score", 0);
    }
    public int GetCurrentScore(){
        return currentScore;
    }
    public int GetTotalKilled(){
        return PlayerPrefs.GetInt("Total Killed", 0);
    }
    public void ResetScore(){
        currentScore = 0;
    }
    public void AddToCurrentScore(){
        currentScore += 1;
        PlayerPrefs.SetInt("Total Killed", GetTotalKilled() + 1);

        if(currentScore > GetHighScore()) {
            PlayerPrefs.SetInt("High Score", currentScore);
        }
    }
    public string GetRank(){
        for (int i = scoreNeededForRank.Length - 1; i >= 0; i--){
            if(GetTotalKilled() > scoreNeededForRank[i]){
                return ranks[i];
            }
        }
        return ranks[0];
    }
    public string GetNextRank(){
        for (int i = scoreNeededForRank.Length - 1; i >= 0; i--)
        {
            if (GetTotalKilled() > scoreNeededForRank[i])
            {
                if (i == scoreNeededForRank.Length - 1)
                {
                    return "Max Rank";
                }
                else
                {
                    return ranks[i + 1] + scoreNeededForRank[i+1] + " High Score";
                }

            }
        }
        return ranks[0];
    }
}
