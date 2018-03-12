using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slashable : MonoBehaviour {


    SlashableSettings settings;
    bool slashed = false;
    float destroyTime = 0;

	// Use this for initialization
	void Start () { 
        
		
	}
	
	// Update is called once per frame
	void Update () {
        if(GetSlashed()){
            if(Time.time >= destroyTime) {
                Destroy(gameObject);
            }
        }
		
	}
    public bool GetSlashed(){
        return slashed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Slasher>())
        {
            AddBlockForce(new Vector3(1, 1, 1));
            Instantiate(settings.sparksObjects, collision.contacts[0].point, settings.sparksObjects.transform.rotation);
            slashed = true;
            destroyTime = Time.time + 5f;
            settings.playerScore.AddToCurrentScore();

        
        }

        if (collision.gameObject.tag == "Hit")
        {
            settings.playerLife.TakeDammage();
        }

    }

    public void CreateSlashable(SlashableSettings settings){
        this.settings = settings;
        AddStartForce(new Vector3(1,1,1));
    }
    public void AddStartForce(Vector3 multiplication){


        gameObject.GetComponent<Rigidbody>().AddForce( new Vector3(multiplication.x * Random.Range(settings.forceMinX, settings.forceMaxX),  multiplication.y * Random.Range(settings.forceMinY, settings.forceMaxY),   multiplication.z * Random.Range(settings.forceMinZ, settings.forceMaxZ)),   ForceMode.VelocityChange);
        gameObject.GetComponent<Rigidbody>().AddTorque(new Vector3(multiplication.x * Random.Range(settings.tourqeMinX,settings.tourqeMaxX), multiplication.y * Random.Range(settings.tourqeMinY, settings.tourqeMaxY), multiplication.z * Random.Range(settings.tourqeMinZ, settings.tourqeMaxZ)), ForceMode.VelocityChange);

    }

    public void AddBlockForce(Vector3 multiplication){
        gameObject.GetComponent<Rigidbody>().AddForce( new Vector3(multiplication.x * Random.Range(settings.blockForceMinX, settings.blockForceMaxX),  multiplication.y * Random.Range(settings.blockForceMinY, settings.blockForceMaxY),   multiplication.z * Random.Range(settings.blockForceMinZ, settings.blockForceMaxZ)),   ForceMode.VelocityChange);
       
    }


}
