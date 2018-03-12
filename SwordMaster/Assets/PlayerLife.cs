using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour {

    public StateBranch loseBranch;
    public int maxLife = 3;
    public AudioSource takeDammageAudio;
    public AudioSource dieAudio;

    int currentLife;
	// Use this for initialization
	void Start () {
        MaxLife();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void MaxLife(){
        currentLife = maxLife;
    }
    public void TakeDammage(){
        currentLife -= 1;
        takeDammageAudio.Play();

        if(IsDead()){
            dieAudio.Play();
            loseBranch.StartBranch();

        }
    }
    public bool IsDead(){
        return currentLife == 0;
    }
    public void SetLife(int newLife){
        this.currentLife = newLife;
    }
    public int GetCurrentLife(){
        return currentLife;
    }
}
