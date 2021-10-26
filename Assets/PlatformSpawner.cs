using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] Pl;
    private float TimeBtwSpawn;
    public float startInterval;
    public float decreaseTime;
    public float minTime = 0.65f;

    // Start is called before the first frame update
    void Start()
    {
      
       
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, Pl.Length);

            var part = Instantiate(Pl[rand], new Vector3(15.6f, -6, 0), Quaternion.identity);
            part.transform.parent = transform;
            TimeBtwSpawn = startInterval;
            if (startInterval > minTime)
            {
                startInterval -= decreaseTime;
            }
        }
        else
            TimeBtwSpawn -= Time.deltaTime;
    }
   
    
}
