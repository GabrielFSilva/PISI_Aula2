﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{

    public PlayerPaddle topPaddle;
    public PlayerPaddle botPaddle;

    
    // Update is called once per frame
    void Update()
    {
        float xinput = Input.GetAxis("Horizontal");
        if (topPaddle != null) topPaddle.SetPaddleVelocity(xinput);
        if (botPaddle != null) botPaddle.SetPaddleVelocity(xinput);
    }
}
