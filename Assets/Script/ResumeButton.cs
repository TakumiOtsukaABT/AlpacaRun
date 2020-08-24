using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeButton : MonoBehaviour
{
    public void onClick()
    {
        Debug.Log("resumeclicked!");
        MyCanvas.SetActive("PauseMenu",false);
        Time.timeScale = 1;
        MyCanvas.SetActive("PauseButton", true);
    }
}
