using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public GameObject bird;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(bird, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
   
}
