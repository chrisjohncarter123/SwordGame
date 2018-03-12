using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLifeGUI : MonoBehaviour {
    public GameObject[] deadIcons;
    public PlayerLife playerLife;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (playerLife.GetCurrentLife() == 3)
        {
            deadIcons[0].SetActive(false);
            deadIcons[1].SetActive(false);
            deadIcons[2].SetActive(false);
        }

        if (playerLife.GetCurrentLife() == 2)
        {
            deadIcons[0].SetActive(true);
            deadIcons[1].SetActive(false);
            deadIcons[2].SetActive(false);
        }
        if (playerLife.GetCurrentLife() == 1)
        {
            deadIcons[0].SetActive(true);
            deadIcons[1].SetActive(true);
            deadIcons[2].SetActive(false);
        }
        if (playerLife.GetCurrentLife() == 0)
        {
            deadIcons[0].SetActive(true);
            deadIcons[1].SetActive(true);
            deadIcons[2].SetActive(true);
        }
		
	}
}
