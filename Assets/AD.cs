using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AD : MonoBehaviour
{
    void Start()
    {
        ShowAd();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void ShowAd()
    {
        Application.ExternalCall("ShowAd");
    }
}
