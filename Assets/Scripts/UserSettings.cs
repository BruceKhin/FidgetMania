using System;
using UnityEngine;

public class UserSettings
{
    public static bool shouldShowAds
    {
        get
        {
            return PlayerPrefs.GetInt("noads") == 0;
        }
    }

    public static event EventHandler AdsTurnedOff;

    public static void TurnOffAds()
    {
        PlayerPrefs.SetInt("noads", 1);
        AdsController.instance.DestroyAds();

        if (AdsTurnedOff != null)
        {
            AdsTurnedOff(null, null);
        }
    }
}

