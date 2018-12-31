using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour {
    public GameObject car;
    public float spawnTime = 3f;
    // Use this for initialization
    void Start () {
        Spawn();
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }
    void Update()
    {

    }

    // Update is called once per frame
     void Spawn()
    {
        if (Time.timeScale != 0)
        {
            Instantiate(car, new Vector3(0, 1, 6), new Quaternion(0, 0, 0, 1));
        }
    }

}
