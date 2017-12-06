using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Test_Fall : Test
{
    [Header("Test Parameters")]
    public float minDrop = 1f;

    private float originalY;

    // Use this for initialization
    void Start()
    {
        originalY = transform.position.y;
    }

    protected override void Check()
    {
        // Is the player lower than mindrop?
        if (transform.position.y != originalY)
        {
            IntegrationTest.Pass(gameObject);
        }
    }
}
