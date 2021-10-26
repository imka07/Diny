using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform Player;
     private  Vector3 pos;
    [SerializeField] private Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {  
        if (!Player)
            Player = FindObjectOfType<D>().transform;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
       
        transform.position = new Vector3(Player.position.x, Player.position.y, offset.z);
        transform.position = Player.position + offset;
    }
   
}
