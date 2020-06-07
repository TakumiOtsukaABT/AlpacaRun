using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AlpacaController : MonoBehaviour
{
    Rigidbody2D rig;
    public float force = 1000.0f;
    Vector2 startPos;
    void Start()
    {
        this.rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            Vector2 result = endPos - startPos;
            switch (fourDirection(result))
            {
                case Direction.UP:
                    Debug.Log("UP");
                    this.rig.AddForce(transform.up * this.force);
                    break;
                case Direction.DOWN:
                    Debug.Log("DOWN");
                    break;
                case Direction.RIGHT:
                    Debug.Log("RIGHT");
                    break;
                case Direction.LEFT:
                    Debug.Log("LEFT");
                    break;
            }
        }


    }
    enum Direction
    {
        UP,
        DOWN,
        RIGHT,
        LEFT
    }

    private Direction fourDirection(Vector2 vector2)
    {
        if (Mathf.Abs(vector2.y) > Mathf.Abs(vector2.x))
        {
            return (vector2.y > 0) ? Direction.UP : Direction.DOWN;
        }
        else {
            return (vector2.x > 0) ? Direction.RIGHT : Direction.LEFT;
        }
    }


}
