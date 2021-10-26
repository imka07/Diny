using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OFFMusic : MonoBehaviour
{
    [Header("AudioMixer Reference")]


    public AudioSource sound;
    [SerializeField] Image offMus;
    [SerializeField] Image onMus;
   bool mut;
    // Start is called before the first frame update
    void Start()
    {
      
        offMus.enabled = false;
        sound.volume = PlayerPrefs.GetFloat("Music");
        AudioListener.pause = mut;
       if(!PlayerPrefs.HasKey("mut"))
       {
            PlayerPrefs.SetInt("mut", 0);
            Load();
       }
    
        AudioListener.pause = mut;
    }
    

    // Update is called once per frame

    public void OnButtonPr()
    {
        if (mut == false)
        {
            mut = true;
            AudioListener.pause = true;
            
        }
        else
        {
            mut = false;
            AudioListener.pause = false;
        }
        if (mut == false)
        {
            onMus.enabled = true;
            offMus.enabled = false;

        }
        else
        {
            onMus.enabled = false;
            offMus.enabled = true;

        }
        Save();
    }
    

    private void Load()
    {
        mut = PlayerPrefs.GetInt("isKnock") == 1;
    }
    public void Save()
    {
        PlayerPrefs.SetInt("isKnock", mut ? 1 : 0);
    }
    
   
   
   
   
}
