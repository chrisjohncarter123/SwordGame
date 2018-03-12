using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSkybox : MonoBehaviour {

    public Color start, mag;
    public float speed;
    public Material skyboxMaterial;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        skyboxMaterial.SetColor("_tintColor", start + new Color(mag.r * Mathf.Cos(Time.time * speed), 
                                                            mag.g * Mathf.Cos(Time.time * speed), 
                                                            mag.g * Mathf.Cos(Time.time * speed) ));
        
		
	}
}
