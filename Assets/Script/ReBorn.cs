using Imran.DataBase;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ReBorn : MonoBehaviour
{
    public RewAd rewAdRed;
    public RewAd rewAdRespawn;
    public RewAd rewAdLightning;
    public RewAd rewAdArmor;

    // Update is called once per frame

    private void Start()
    {
        //PlayerPrefs.GetFloat("Time");
        rewAdRed.OnAdCompleted += RedAdCompleted;
        rewAdRespawn.OnAdCompleted += RespawnAdCompleted;
        rewAdLightning.OnAdCompleted += BlueAdCompleted;
        rewAdArmor.OnAdCompleted += YellowAdCompleted;
    }

    void Update()
    {
        
    }

    public void ActivateRedOne()
    {
       
        rewAdRed.Show();
    }

    public void ActivateLightningOne()
    {
        
        rewAdLightning.Show();
    }
    public void ActivateRespawnOne()
    {
        rewAdRespawn.Show();
    }
    public void ActivateYellowOne()
    {
       rewAdArmor.Show();
    }

    private void BlueAdCompleted()
    {
        DataBase.SaveStartBonus(2);
        SceneManager.LoadScene(1);
    }
    private void YellowAdCompleted()
    {
        DataBase.SaveStartBonus(3);
        SceneManager.LoadScene(1);
    }

    private void RedAdCompleted()
    {
        DataBase.SaveStartBonus(1);
        SceneManager.LoadScene(1);
    }

    private void RespawnAdCompleted()
    {
        FindObjectOfType<D>().Respawn();
        var rewAds = GetComponents<RewAd>();
        foreach (var rewAd in rewAds)
        {
            rewAd.LoadAd();
        }
    }
}
