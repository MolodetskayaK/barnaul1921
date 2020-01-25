﻿using System.Collections;
using UnityEngine;

public class ControllerAnimationE : MonoBehaviour
{

    public Transform player;
    static Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(player.position, this.transform.position) < 10)
        {
            Vector3 direction = player.position - this.transform.position;
            direction.y = 0;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                                          Quaternion.LookRotation(direction), 0.1f);
            anim.SetBool("IsIdle", false);
            if (direction.magnitude > 5)
            {
                this.transform.Translate(0, 0, 0.05f);
                anim.SetBool("IsWalk", true);
                anim.SetBool("IsAttack", false);
            }
            else
            {
                anim.SetBool("IsAttack", true);
                anim.SetBool("IsWalk", false);
            }

        }
        else
        {
            anim.SetBool("IsIdle", true);
            anim.SetBool("IsWalk", false);
            anim.SetBool("IsAttack", false);
        }

    }
}

