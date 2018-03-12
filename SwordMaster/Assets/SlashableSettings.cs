using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashableSettings : MonoBehaviour {

    public PlayerLife playerLife;
    public PlayerScore playerScore;
    public int slashableLayer = 9;
    public float forceMinX, forceMaxX, forceMinY, forceMaxY, forceMinZ, forceMaxZ;
    public float tourqeMinX, tourqeMaxX, tourqeMinY, tourqeMaxY, tourqeMinZ, tourqeMaxZ;
    public float startPositionRadius = 2f;

    public float blockForceMinX, blockForceMaxX, blockForceMinY, blockForceMaxY, blockForceMinZ, blockForceMaxZ;
    public GameObject[] slashables;

    public float newCreatorTime = 10;
    public float newCreatorSlashableTimeAdd = 1;
    public GameObject sparksObjects;
    public Transform slashablesParent;

    float gameplayTime = 0;
    float createNextCreatorTime = 0;
    float createTimeTime = 0;
    int waveNumber;

    PlayState playState;
    enum PlayState{
        Playing,
        NotPlaying
    }

	// Use this for initialization
	void Start () {
        Physics.IgnoreLayerCollision(slashableLayer, slashableLayer);
        playState = PlayState.NotPlaying;
		
	}

    private void FixedUpdate()
    {
        if (playState == PlayState.Playing)
        {
            gameplayTime += Time.deltaTime;
        }
    }
    // Update is called once per frame
    void Update () {

        if (playState == PlayState.Playing)
        {
            if (GetGameplayTime() > createNextCreatorTime)
            {
                createNextCreatorTime += newCreatorTime;
                waveNumber += 1;

                SlashableCreator create = gameObject.AddComponent<SlashableCreator>();
                create.time = createTimeTime + newCreatorSlashableTimeAdd;
                createTimeTime = create.time;
                create.slashable = (slashables[Random.Range(0, slashables.Length - 1)]);
                create.settings = this;

            }
        }
        
		
	}

    public float GetGameplayTime(){
        return gameplayTime;
    }

    public int GetWaveNumber(){
        return waveNumber;
    }

    public void StartGame(){
        playerScore.ResetScore();
        playerLife.MaxLife();
        playState = PlayState.Playing;
        
    }

}
