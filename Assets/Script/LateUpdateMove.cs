﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LateUpdateMove : MonoBehaviour
{
    void LateUpdate()
    {
        this.transform.Translate(0, 0, Time.deltaTime); // Move the character in the Z direction, using 'time elapsed between updates' as amount.
    }
}
