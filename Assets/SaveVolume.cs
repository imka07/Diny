using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveVolume : MonoBehaviour
{
    public AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("Music", sound.volume);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
