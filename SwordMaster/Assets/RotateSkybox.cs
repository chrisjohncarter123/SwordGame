using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSkybox : MonoBehaviour {
    public float speed = .1f;
    public Material skyboxMaterial;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        skyboxMaterial.SetFloat("_Rotation", Time.time * speed);
		
	}
}
