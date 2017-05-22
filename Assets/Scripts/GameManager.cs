using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public int currentSpinner = 0;
    private int spinnerCount = 0;
    public Image mainFidget;
    public Image bg;
//    public GameObject spinnerCountGO;
    public GameObject spinMeGO;
    public GameObject spinnerSelectionGO;
    public GameObject bgSelectionGO;
//    public GameObject speedSelectionGO;
    public Button blockAdsButton;
    public GameObject iosConfirm;
    private Slider speedSlider;
    private Text spinnerCountText;
    public Sprite[] spinners;
    public Sprite[] backgrounds;
    private int currentBG;

	void Awake()
    {
        UserSettings.AdsTurnedOff += UserSettings_AdsTurnedOff;
        bg = GameObject.Find("Background").GetComponent<Image>();
        currentSpinner = PlayerPrefs.GetInt("currentSpinner", 0);
        currentBG = PlayerPrefs.GetInt("currentBG", 0);
//        if (speedSelectionGO)
//        {
//            speedSlider = speedSelectionGO.GetComponent<Slider>();
//            speedSlider.value = PlayerPrefs.GetFloat("spinnerSpeed", 0.0f) / 50.0f;
//            speedSlider.onValueChanged.AddListener(delegate { setSpinnerSpeed(); });
//        }
        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
//            spinnerCount = PlayerPrefs.GetInt("spinnerCount", 0);
//            if (spinnerCountGO != null)
//            {
//                spinnerCountText = spinnerCountGO.GetComponent<Text>();
//            }
            setSpinner(currentSpinner);

            if (blockAdsButton != null)
            {
                blockAdsButton.gameObject.SetActive(UserSettings.shouldShowAds);
            }
//            if (spinnerCount == 0)
//            {
//                spinMeGO.SetActive(true);
//                spinnerCountGO.SetActive(false);
//            }
//            else
//            {
//                spinMeGO.SetActive(false);
//                spinnerCountGO.SetActive(true);
//            }
        }
        setBG(currentBG);
    }

    void UserSettings_AdsTurnedOff (object sender, System.EventArgs e)
    {
        if (blockAdsButton != null)
        {
            blockAdsButton.gameObject.SetActive(false);
        }
    }

    void Start()
    {
        //hideAllSubs();
    }

    void Update()
    {
        if (spinnerCountText)
        {
            spinnerCount = PlayerPrefs.GetInt("spinnerCount", 0);
            spinnerCountText.text = "Spins: " + spinnerCount;
        }
    }

    private void hideAllSubs()
    {
        if(spinnerSelectionGO)
            spinnerSelectionGO.SetActive(false);
        if(bgSelectionGO)
            bgSelectionGO.SetActive(false);
//        if (speedSelectionGO)
//            speedSelectionGO.SetActive(false);
    }

    public void showSpinnerSelection()
    {
        hideAllSubs();
        spinnerSelectionGO.SetActive(true);
    }

    public void showBGSelection()
    {
        hideAllSubs();
        bgSelectionGO.SetActive(true);
    }

//    public void showSpeedSelection()
//    {
//        hideAllSubs();
//        speedSelectionGO.SetActive(true);
//    }
	
    public void setSpinner(int num)
    {
        PlayerPrefs.SetInt("currentSpinner", num);
        currentSpinner = num;

        if(SceneManager.GetActiveScene().name == "MainMenu" && mainFidget != null)
        {
            mainFidget.sprite = spinners[num];
        }
        else if (SceneManager.GetActiveScene().name == "Customization")
        {
            gotoScene("MainMenu");
        }

        if (spinnerSelectionGO)
        {
            spinnerSelectionGO.SetActive(false);
        }
    }

//    private void setSpinnerSpeed()
//    {
//        float value = speedSlider.value * 49 + 1;
//        PlayerPrefs.SetFloat("spinnerSpeed", value);
//    }

    public void setBG(int num)
    {
        PlayerPrefs.SetInt("currentBG", num);
        if (bg)
        {
            bg.sprite = backgrounds[num];
        }
//        if (bgSelectionGO)
//        {
//            bgSelectionGO.SetActive(false);
//        }
    }

    public void gotoScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void setSpinnerSpeed(float num)
    {
        PlayerPrefs.SetFloat("spinnerSpeed", num);
    }

    public void updateSpinnerCount()
    {
        spinnerCount++;
        PlayerPrefs.SetInt("spinnerCount", spinnerCount);
    }

    public void BuyNoAdsClick()
    {
        #if UNITY_IOS
        iosConfirm.gameObject.SetActive(true);
        #elif UNITY_ANDROID
        PerformPurchase();
        #endif
    }

    public void PerformPurchase()
    {
        Purchaser.instance.BuyNonConsumable();
        CancelConfirm();
    }

    public void CancelConfirm()
    {
        iosConfirm.SetActive(false);
    }

    public void RestoreClick()
    {
        Purchaser.instance.RestorePurchases();
        CancelConfirm();
    }
}
