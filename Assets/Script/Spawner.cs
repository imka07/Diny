using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] bird;
    private float TimeBtwSpawn;
    public float startInterval;
    public float decreaseTime;
    public float minTime = 0.65f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
        if (TimeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, bird.Length);
          
            Instantiate(bird[rand], transform.position, Quaternion.identity);
            TimeBtwSpawn = startInterval;
           if(startInterval > minTime)
           {
                startInterval -= decreaseTime;
           }
        }
        else
            TimeBtwSpawn -= Time.deltaTime;
       
    }
    
}
