﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("Destroy", 2);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void Destroy()
    {
        Destroy(gameObject);
    }
}
