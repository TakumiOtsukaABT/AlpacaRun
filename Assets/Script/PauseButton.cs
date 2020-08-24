using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    public void onClick()
    {
        Debug.Log("pauseclicked!");
        gameObject.SetActive(false);
        Time.timeScale = 0;
        MyCanvas.SetActive("PauseMenu", true);
    }
}
