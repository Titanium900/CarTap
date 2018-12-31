using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDrive : MonoBehaviour {
    // Use this for initialization
    void Start () {
        //rand = Random.Range(1, 361);
        Invoke("Destroy",20);
        //transform.rotation = Quaternion.AngleAxis(90, new Vector3(1, 0, 0));

    }
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(GameObject.Find("Sphere").transform.position, new Vector3(0, 1, 0), 20 * Time.deltaTime);
    }
    void Destroy()
    {
        Destroy(GameObject.Find("Car1.2(Clone)"));
    }
}
