using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quest : MonoBehaviour
{
    public GameObject quest1;
    public GameObject LVL;
    public GameObject Skins;
    public GameObject o;
           public GameObject n;
           public GameObject e;
    public GameObject f;

    // Start is called before the first frame update
    void Start()
    {
        quest1.SetActive(false);
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenLVL()
    {
        LVL.SetActive(true);
       
    }
    public void OpenSkins()
    {
        Skins.SetActive(true);
      
    }
    public void OpenQ()
    {
        o.SetActive(false);
        n.SetActive(false);
        e.SetActive(false);
        f.SetActive(false);
     
        quest1.SetActive(true);
       
    }
    public void CloseQ()
    {
        quest1.SetActive(false);
        o.SetActive(true);
        n.SetActive(true);
        e.SetActive(true);
        f.SetActive(true);
       
    }
    public void CloseLVL()
    {
        LVL.SetActive(false);
        

    }
    public void CloseSkins()
    {
        Skins.SetActive(false);
        
    }
}
