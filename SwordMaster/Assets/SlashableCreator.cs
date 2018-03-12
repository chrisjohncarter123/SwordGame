using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashableCreator : MonoBehaviour {

    public SlashableSettings settings;
    public float time;
    public float timeOffset = 0;
    public GameObject slashable;

    int created = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > timeOffset)
        {
            if (Time.time > timeOffset + (created * time))
            {
                CreateSlashable();
                created += 1;
            }
        }
	}
    void CreateSlashable(){
        Vector3 position = transform.position + 
                                    settings.startPositionRadius *
                                    new Vector3(Random.insideUnitCircle.x,
                                                Random.insideUnitCircle.y,
                                                0) ;
        
        GameObject newSlashable = Instantiate(slashable, position, Quaternion.identity);
        newSlashable.GetComponent<Slashable>().CreateSlashable(settings);
        newSlashable.transform.parent = settings.slashablesParent;
    }

}
