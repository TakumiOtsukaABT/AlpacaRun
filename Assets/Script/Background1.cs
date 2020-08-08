using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background1 : MonoBehaviour
{
    public float scrollSpeed;
    public Vector2 startPos;
    const float imageBound = 22.455f;
    public float speedTimes = 3.9f;
    GameObject alpaca;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        alpaca = GameObject.Find("Alpaca1200");
    }

    // Update is called once per frame
    void Update()
    {
        scrollSpeed = -alpaca.GetComponent<AlpacaController>().speed*speedTimes;
        float newPos = Mathf.Repeat(Time.time * scrollSpeed, imageBound);
        transform.position = startPos + Vector2.right * newPos;
    }
}
