﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// -----------
/// CISC 496 - Group P1 - Project: Eye Say
/// Description: Script to bob the skull up and down
/// How to use:
///     Attach to 'Empty' object that is child of the main 'Empty' object
/// Written by: Sammy Chan
/// ---------- 

public class SkullShake : MonoBehaviour
{
    private float originalY;
    private bool goingUp = true;
    private float offset = 0.5f;
    private float maxTop;
    private float maxBot;

    private void Start()
    {
        originalY = transform.localPosition.y;
        maxTop = originalY + offset;
        maxBot = originalY - offset;
    }


    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.y > maxTop)
        {
            goingUp = false;
        }
        else if (transform.localPosition.y < maxBot)
        {
            goingUp = true;
        }

        if (goingUp)
        {
            transform.Translate(Vector3.up * 2 * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.down * 2 * Time.deltaTime);
        }

    }
}
