using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalGenerator : MonoBehaviour
{
    public GameObject[] order;
    public float[] interval;
    public bool done = false;
    public float yaxis = 0.8f;

    float a = 0.0f;
    int i = 0;
    public float time = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        done = false;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 3.0f)
        {

            try
            {
                if (time - 3.0f > interval[i])
                {
                    Instantiate(order[i], new Vector2(20.0f, yaxis), Quaternion.identity);
                    i++;
                }
            }catch(IndexOutOfRangeException)
            {
                a += Time.deltaTime;
                if (a > 5.0f)
                {
                    done = true;
                }
            }






        }
    }
}
