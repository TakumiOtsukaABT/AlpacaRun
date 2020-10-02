using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarControll : MonoBehaviour
{
    public string stageName;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt(stageName) == 1)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
