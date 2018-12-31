using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPivotRotate : MonoBehaviour {
    int randz;
    // Use this for initialization
    void Start () {
        randz = Random.Range(0, 361);
        transform.rotation *= Quaternion.AngleAxis(RotateAll.rotate/2, new Vector3(0, 1, 0));
        transform.rotation *= Quaternion.AngleAxis(randz, new Vector3(0,0,1));
        //Invoke("Destroy", 18);
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(1,0,0) * -100 * Time.deltaTime);
    }
    void Destroy()
    {
        Strikes.strike = Strikes.strike + 1;
        Destroy(gameObject);
    }
}
