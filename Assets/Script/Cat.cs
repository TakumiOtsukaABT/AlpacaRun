using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Enemy
{
    public int state;
    public float sec;
    private float secTemp;
    private float rand;
    private float temp;
    Animator animator;


    new void Start()
    {
        base.Start();
        state = 0;
        rand = Random.Range(0.2f, 1.5f);
        temp = rand;
        animator = GetComponent<Animator>();
        secTemp = sec;
    }

    public override void individualMove()
    {
        switch (state)
        {
            case 0:
                this.transform.Translate(-0.1f, 0, 0);
                rand -= Time.deltaTime;
                if (rand < 0.0f)
                {
                    state = 1;
                }
                break;
            case 1:
                sec -= Time.deltaTime;
                if (sec<0.0f)
                {
                    nobiFin();
                }
                break;
        }
        this.animator.SetInteger("state", state);

    }

    private void nobiFin()
    {
        rand = temp;
        sec = secTemp;
        state = 0;
        return;
    }

}
