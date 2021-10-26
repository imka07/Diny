using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarClouds : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cloud;
    void Start()
    {
        Instantiate(cloud, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
