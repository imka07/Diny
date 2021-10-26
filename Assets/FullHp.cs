using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class FullHp : MonoBehaviour
{
    
    private string ReWUnittId = "ca-app-pub-3940256099942544/5354046379";
    private RewardedAd rewAd;

    private void OnEnable()
    {
        rewAd = new RewardedAd(ReWUnittId);
        AdRequest adRequest = new AdRequest.Builder().Build();
        rewAd.LoadAd(adRequest);
        rewAd.OnUserEarnedReward += HandleUserEarnedReward;


    }
    private void HandleUserEarnedReward(object sender, Reward e)
    {
        FindObjectOfType<D>().health = 3;
    }

    // Update is called once per frame
    public void Show()
    {
        if (rewAd.IsLoaded())
            rewAd.Show();
    }
}


