using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;

public class BannerManager : MonoBehaviour
{
    private string playStoreID = "3811513";
    private string appStoreID = "3811512";

    private string bannerAd = "Banner";

    public bool isTargetPlayStore;
    public bool isTestAd;

    IEnumerator Start()
    {
        InitializeAdvertisement();

        while (!Advertisement.IsReady(bannerAd))
        {
            yield return null;
        }
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        Advertisement.Banner.Show(bannerAd);
    }
    private void InitializeAdvertisement()
    {
        if (isTargetPlayStore) { Advertisement.Initialize(playStoreID,isTestAd); return; }
        Advertisement.Initialize(appStoreID, isTestAd);
    }
}
