using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capibala : Enemy
{
    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
        transform.localScale = new Vector3(Random.Range(-1, 1) < 0 ? -0.5f : 0.5f, 0.5f, 0.5f);
    }

    // Update is called once per frame
    //void Update()
    //{
    //}


}
