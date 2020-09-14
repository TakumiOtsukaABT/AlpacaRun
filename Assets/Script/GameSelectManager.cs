using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSelectManager : MonoBehaviour
{
    private bool once;
    private void Start()
    {
        once = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (once)
        {
            GameObject.Find("AdManager").GetComponent<AdManager>().playInterstitialAd();
            once = false;
        }
        
    }
}
