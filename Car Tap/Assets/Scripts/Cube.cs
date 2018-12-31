using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {
    float rotate;
    // Use this for initialization
    void Start()
    {
        transform.rotation *= Quaternion.AngleAxis(RotateAll.rotate, new Vector3(0, 1, 0));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 1, 0) * 1 * Time.deltaTime);
        rotate += 1 * Time.deltaTime;
    }
}