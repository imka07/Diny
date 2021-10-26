using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudSpawner : MonoBehaviour
{
    [SerializeField] private GameObject cloud;
    private float TimeBtwSpawn;
    public float startInterval;
    public float decreaseTime;
    public float minTime = 0.65f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeBtwSpawn <= 0)
        {
           

            Instantiate(cloud, transform.position, Quaternion.identity);
            TimeBtwSpawn = startInterval;
            
        }
        else
            TimeBtwSpawn -= Time.deltaTime;

    }
}

