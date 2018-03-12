using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerScoreGUI : MonoBehaviour {

    public PlayerScore playerScore;
    public Text highScoreText, totalKilledText, rankText, nextRankText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        highScoreText.text = playerScore.GetHighScore().ToString();
        totalKilledText.text = playerScore.GetTotalKilled().ToString();
        rankText.text = playerScore.GetRank().ToString();
        nextRankText.text = playerScore.GetNextRank();
		
	}
}
