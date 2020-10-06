using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeButton : MonoBehaviour
{
    public void onClick()
    {
        Debug.Log("resumeclicked!");
        MyCanvas.SetActivebyTags("StartTag", true);
        MyCanvas.SetActive("PauseMenu",false);
        Time.timeScale = 1;

    }
}
