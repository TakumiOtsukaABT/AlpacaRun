using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background1 : MonoBehaviour
{
    public float scrollSpeed = -5f;
    public Vector2 startPos;
    const float imageBound = 22.455f;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * scrollSpeed, imageBound);
        transform.position = startPos + Vector2.right * newPos;
    }
}
