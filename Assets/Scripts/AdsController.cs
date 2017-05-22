using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using UnityEngine.UI;
using System;

public class AdsController : MonoBehaviour
{
    public static AdsController instance;

	public InterstitialAd interstitial;

    BannerView bannerAd;

    AdsController()
    {
        instance = this;
    }

	void Awake ()
    {
		LoadAd(SceneManager.GetActiveScene().name);
	}
	
	// Update is called once per frame
	void Update () {
		if(interstitial!= null && interstitial.IsLoaded()){
			 interstitial.Show();
             interstitial = null;
		 }
         
	}

    void LoadAd(string scene)
    {
        RequestInterstitial("ca-app-pub-8590749586245563/3919242533");
        RequestBanner("ca-app-pub-8590749586245563/9965776133");

//        switch(scene)
//        {
//            case "MainMenu":
//                RequestInterstitial("ca-app-pub-8590749586245563/1128409736");
//                RequestBanner("ca-app-pub-8590749586245563/7174943337");
//                break;
//            case "About":
//                RequestInterstitial("ca-app-pub-8590749586245563/3919242533");
//             	RequestBanner("ca-app-pub-8590749586245563/9965776133");
//                break;
//            case "Tricks":
//                RequestInterstitial("ca-app-pub-8590749586245563/2605142935");
//             	RequestBanner("ca-app-pub-8590749586245563/8651676539");
//                break;
//            case "Customization":
//                RequestInterstitial("ca-app-pub-8590749586245563/2605142935");
//                RequestBanner("ca-app-pub-8590749586245563/8651676539");
//                break;
//		}
	 }

    private void RequestBanner(string adUnit)
    {
        #if UNITY_EDITOR
            string adUnitId = "unused";
        #elif UNITY_ANDROID
            string adUnitId = adUnit;
        #elif UNITY_IPHONE
            string adUnitId = adUnit;
        #else
            string adUnitId = "unexpected_platform";
        #endif
        // Create a 320x50 banner at the top of the screen.
        bannerAd = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        bannerAd.LoadAd(request);
        bannerAd.Show();
    }

    private void RequestInterstitial(string adUnit)
    {
        #if UNITY_ANDROID
            string adUnitId = adUnit;
        #elif UNITY_IPHONE
            string adUnitId = adUnit;
        #else
            string adUnitId = "unexpected_platform";
        #endif

        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        interstitial.LoadAd(request);
    }

        public void DestroyAds()
        {
            if (interstitial != null)
            {
                interstitial.Destroy();
            }

            if (bannerAd != null)
            {
                bannerAd.Destroy();
            }
        }
}
