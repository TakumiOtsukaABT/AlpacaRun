using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit : Enemy
{
    Rigidbody2D rig;
    public float force = 1000.0f;
    public float interval;
    Animator animator;
    public float countDown;
    bool startCount = false;
    float countFromSpawn;

    new void Start()
    {
        base.Start();
        rig = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        interval = Random.Range(0.7f, 4.0f);
        countDown = interval/10;
        animator.SetFloat("IdleSpeed", interval/10);
        countFromSpawn = 0;
    }

    public override void individualMove()
    {
        if (rig.velocity.y == 0)
        {
            this.animator.SetBool("Ground", true);
            countFromSpawn += Time.deltaTime;
        }
        if (countFromSpawn > interval && !startCount && rig.velocity.y == 0)
        {
            countFromSpawn = 0;
            ready();
        }

        if (startCount)
        {
            countDown-=Time.deltaTime;
        }
        this.animator.SetFloat("count", countDown);

        if (countDown < 0)
        {
            jump();
            startCount = false;
            countDown = interval/10;
        }

    }

    private void ready()
    {
        this.animator.SetBool("Ground", false);
        startCount = true;
    }

    private void jump()
    {
        rig.AddForce(transform.up * force);
    }
}
