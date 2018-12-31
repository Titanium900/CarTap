using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Strikes : MonoBehaviour {
    public static double strike;
    public GameObject endScreen;
    public bool end = false;
    Text text;
    // Use this for initialization
    void Start () {
        text = GetComponent<Text>();
        strike = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (strike <= 0)
        {
            text.text = "Strikes:";
        }
        if (strike == 1)
        {
            text.text = "Strikes: I";
        }
        if (strike == 2)
        {
            text.text = "Strikes: I I";
        }
        if (strike >= 3)
        {
            text.text = "Strikes: I I I";
            if (end == false)
            {
                Instantiate(endScreen, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 1));
                end = true;
            }
        }
    }
}
