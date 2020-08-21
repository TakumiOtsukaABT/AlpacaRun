using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Enemy
{
    public override void individualMove()
    {
        transform.Translate(-0.15f, 0, 0);
    }
}
