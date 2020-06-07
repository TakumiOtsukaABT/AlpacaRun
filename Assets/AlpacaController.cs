using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlpacaController : MonoBehaviour
{
    Rigidbody2D rig;
    public float force = 680.0f;
    // Start is called before the first frame update
    void Start()
    {
        this.rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rig.AddForce(transform.up * this.force);
        }


    }
}
