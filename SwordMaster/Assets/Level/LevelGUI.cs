using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelGUI : MonoBehaviour {


    public GameObject LevelPannel;
    public int levelCount;
    public Transform parent;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < levelCount; i++) {
            GameObject newLevel = Instantiate(LevelPannel);
            newLevel.name = "Level Button " + i;
            newLevel.transform.parent = parent;
            newLevel.GetComponent<LevelButton>().SetLevelButton(i);
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
