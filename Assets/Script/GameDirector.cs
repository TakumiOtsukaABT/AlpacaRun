using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;


public class GameDirector : MonoBehaviour
{
    GameObject alpaca;
    AnimalGenerator generator;
    public float loseXAxis = -6.0f;
    float count = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        alpaca = GameObject.Find("Alpaca1200");
        Time.timeScale = 1.0f;
        count = 4.0f;
        generator = GameObject.Find("Generator").GetComponent<AnimalGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        count -= Time.deltaTime;
        if (count <1.0f)
        {
            MyCanvas.SetActive("CountPanel", false);
        }
        else
        {
            int number = (int)count;
            GameObject.Find("CountText").GetComponent<Text>().text = number.ToString();
        }
        if (alpaca.transform.position.x < loseXAxis)
        {
            Debug.Log("LOSE");
            alpaca.GetComponent<AlpacaController>().disable = true;
            MyCanvas.SetActive("PauseButton", false);
            MyCanvas.SetActive("LosePanel",true);

        }else if (generator.done)
        {
            MyCanvas.SetActive("PauseButton", false);
            MyCanvas.SetActive("WinPanel", true);
            PlayerPrefs.SetInt(SceneManager.GetActiveScene().name, 1);
        }
    }
}
