using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LvlManager : MonoBehaviour
{
    public GameObject pause;
    public GameObject oas;
   
    // Start is called before the first frame update
    void Start()
    {
        pause.SetActive(false);
        oas.SetActive(true);
    }
    private void Awake()
    {
        //PlayerPrefs.SetFloat("Время", Time.timeScale = 1);
    }

    // Update is called once per frame
    void Update()
    {
        InputPause();
        var s = FindObjectOfType<Score>();
        s.ScoreIn(true);

        if (Input.GetKeyDown(KeyCode.A)) print(Time.timeScale);
    }
    public void OpenPause()
    {
        var s = FindObjectOfType<Score>();
        s.ScoreIn(false);
        oas.SetActive(false);
        pause.SetActive(true);
        Time.timeScale = 0;
        
    }
    private float test = 0;
    private void InputPause()
    {
        
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            test++;
        }
        switch(test)
        {

            case 1:
                OpenPause();
                break;
            case 2:
                OffPause();
                test = 0;
                break;
        }
       
    }
    public void OffPause()
    {
      
        pause.SetActive(false);
        Time.timeScale = 1;
        oas.SetActive(true) ;
    }
    public void ToMenu()
    {
        //PlayerPrefs.GetFloat("Время");
        OffPause();
        //Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    



}
