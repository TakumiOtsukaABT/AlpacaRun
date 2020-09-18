using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background1 : MonoBehaviour
{
    private float scrollSpeed;
    public Vector2 startPos;
    public float imageBound = 22.455f;
    public float speedTimes = 3.9f;
    float newPos;
    /*scroll to alpaca no speed chousei*/
    public float speedAdjust = 13.0f;
    GameObject alpaca;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        alpaca = GameObject.Find("Alpaca1200");
        newPos = Mathf.Repeat(-speedTimes, imageBound);

    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }
        scrollSpeed = -(alpaca.GetComponent<AlpacaController>().speed/ speedAdjust) * (Time.deltaTime * 60);
        newPos = Mathf.Repeat(newPos + scrollSpeed, imageBound);
        transform.position = startPos + Vector2.right * newPos;
    }
}
