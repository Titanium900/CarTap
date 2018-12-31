using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHit : MonoBehaviour
{
    public GameObject smoke;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("car"))
        {
            Strikes.strike += 0.5;
            Destroy(other.gameObject);
            Destroy();
        }
    }
    void OnMouseDown()
    {
        Destroy();
        Score.score += 1;
    }
    void Destroy()
    {
        Instantiate(smoke, this.transform.position, this.transform.rotation);
        Destroy(gameObject);
    }
}
