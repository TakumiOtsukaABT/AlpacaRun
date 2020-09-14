using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour
{
    private string playStoreID = "3811513";
    private string appStoreID = "3811512";

    private string interstitialAd = "video";

    public bool isTargetPlayStore;
    public bool isTestAd;

    private void Start()
    {
        InitializeAdvertisement();
    }
    private void InitializeAdvertisement()
    {
        if (isTargetPlayStore) { Advertisement.Initialize(playStoreID,isTestAd); return; }
        Advertisement.Initialize(appStoreID, isTestAd);
    }
    public void playInterstitialAd()
    {
        if (!Advertisement.IsReady(interstitialAd)) { return; }
        Advertisement.Show();
    }
}
