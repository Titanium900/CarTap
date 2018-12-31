using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetOrbit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(GameObject.Find("Sun").transform.position, new Vector3(0, 1, 0), 5 * Time.deltaTime);
    }
}
