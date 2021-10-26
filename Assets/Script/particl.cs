using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class particl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        Destroy(this.gameObject, 0.5f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
