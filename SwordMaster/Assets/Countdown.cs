using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

    public Text text;
    public string[] texts;
    bool started = false;
	// Use this for initialization
	void Start () {
		
	}
    public void StartCountdown(){
        started = true;    
    }

	// Update is called once per frame
	void Update () {
        if(started) {
            //text.text = 
        }
		
	}
}
