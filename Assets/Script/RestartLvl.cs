using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartLvl : MonoBehaviour
{
    public GameObject oas;
    // Start is called before the first frame update
    void Start()
    {
        oas.SetActive(true);   
    }
    public void Restart()
    {
        FindObjectOfType<D>().health = 1;
        oas.SetActive(true);
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
