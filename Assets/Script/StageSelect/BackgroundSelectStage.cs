using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSelectStage : MonoBehaviour
{
    public float scrollSpeed;
    public Vector2 startPos;
    public const float imageBound = 22.455f;
    float speedTimes = 3.9f;
    float newPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        newPos = Mathf.Repeat(-speedTimes, imageBound);

    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }
        newPos = Mathf.Repeat(newPos + scrollSpeed, imageBound);
        transform.position = startPos + Vector2.right * newPos;
    }
}
