using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordController : MonoBehaviour {

    public float xBoundsMin, xBoundsMax, yBoundsMin, yBoundsMax, zBoundsMin, zBoundsMax;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        transform.localPosition += new Vector3(x, y, 0);

        transform.localPosition = new Vector3(
            Mathf.Clamp(transform.localPosition.x, xBoundsMin, xBoundsMax),
            Mathf.Clamp(transform.localPosition.y, yBoundsMin, yBoundsMax),
            Mathf.Clamp(transform.localPosition.z, zBoundsMin, zBoundsMax)

        );


	}

    public void SetStartingPosition(){
        transform.position = Vector3.zero;
    }
}
