using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScoreCurrentGUI : MonoBehaviour {

    public PlayerScore playerScore;
    public Text currentPlayerScoreText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        currentPlayerScoreText.text = playerScore.GetCurrentScore().ToString();
		
	}
}
