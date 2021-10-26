using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MENumanager : MonoBehaviour
{

   
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) print(Time.timeScale);
    }
   
   
   
    public void ToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    
        Destroy(GameObject.Find("Audio Source"));
       
    }

}
