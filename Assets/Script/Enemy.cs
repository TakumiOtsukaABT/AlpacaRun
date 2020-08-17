using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject alpaca,background;
    protected float scrollSpeed;//基本速度
    float alpacaSpeed, speedAdjust;

    // Start is called before the first frame update
    void Start()
    {
        background = GameObject.Find("dupli2");
        alpaca = GameObject.Find("Alpaca1200");
        speedAdjust = background.GetComponent<Background1>().speedAdjust;
    }

    // Update is called once per frame
    void Update()
    {
        alpacaSpeed = alpaca.GetComponent<AlpacaController>().speed;
        scrollSpeed = -alpacaSpeed / speedAdjust;
        standardMove();
        individualMove();
        if (destroyCondition())
        {
            Destroy(gameObject);
        }
    }

    public virtual void individualMove()
    {
        return;
    }

    public virtual void standardMove()
    {
        this.transform.Translate(scrollSpeed, 0, 0);
    }

    public virtual bool destroyCondition()
    {
        return this.transform.position.x < -15.0f;
    }
}
