using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleInstantiator : MonoBehaviour {

    public GameObject baseObject;
    public float radius;
    public float number;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < number; i++){
            float t = i * (1 / number) * Mathf.PI * 2;

            float x = radius * Mathf.Cos(t);
            float y = radius * Mathf.Sin(t);

            GameObject newObject = Instantiate(baseObject, transform.position + new Vector3(x, y, 0), baseObject.transform.rotation);
            newObject.transform.parent = transform;
            newObject.name = "CircleInstansiator Object Clone " + i;
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
