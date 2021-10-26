using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSound : MonoBehaviour
{
    private static BGSound bg;
  
    // Start is called before the first frame update
    void Awake()
    {
      
        if (bg == null)
        {
            bg = this;
            DontDestroyOnLoad(bg);
        }
        else
            Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
