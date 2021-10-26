using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class RewAd : MonoBehaviour
{
    private const string REWARD_AD_ID = "ca-app-pub-8859941314028699/9672730561";
    private RewardedAd _rewardedAd;
    public delegate void OnAdCompletedHandler();
    public OnAdCompletedHandler OnAdCompleted;

    private void Start()
    {
        _rewardedAd = new RewardedAd(REWARD_AD_ID);
        _rewardedAd.OnUserEarnedReward += RewardEarnHandler;
        LoadAd();
    }

    public void LoadAd()
    {
        var adRequest = new AdRequest.Builder().Build();
        _rewardedAd.LoadAd(adRequest);
    }

    private void RewardEarnHandler(object sender, Reward e)
    {
        OnAdCompleted?.Invoke();
    }

    public void Show()
    {
        if (_rewardedAd.IsLoaded())
        {
            _rewardedAd.Show();
        }
        else
        {
            //Debug.LogError("Реклама не загружена");
        }
    }
}
