﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateDebug : MonoBehaviour {


    public string message;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartState(){
        Debug.Log(message);
    }
    public void EndState()
    {

    }
}
