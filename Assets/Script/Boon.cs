using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boon : MonoBehaviour
{
    [SerializeField] private GameObject LightEx;
    public static Boon Instance { get; private set; }
    public bool isClicked;
    private void Start()
    {
        Instance = this;
        gameObject.SetActive(false);
    }
    private void Update()
    {
     
    }
    public void Boom()
    {
        isClicked = true; 
        gameObject.SetActive(false);
        var birds = FindObjectsOfType<Bird>();
        if (birds.Length > 0)
        {
            for (int i = 0; i < birds.Length; i++)
            {
                var s = FindObjectOfType<Score>();
                s.score1 += 5;
                print(i);
                birds[i].Die();    
                Instantiate(LightEx, birds[i].transform.position, Quaternion.identity);
                
            }
        }
    }
}
