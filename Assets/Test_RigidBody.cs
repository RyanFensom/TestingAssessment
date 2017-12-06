using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_RigidBody : Test
{
    [Header("Test Parameters")]
    public Rigidbody rigid;

    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    protected override void Check()
    {
        // Is the player lower than mindrop?
        if (rigid != null)
        {
            IntegrationTest.Pass(gameObject);
        }
    }
}
