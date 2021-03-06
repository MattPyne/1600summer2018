﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]

public class Animal : ScriptableObject {

    // Use this for initialization
    public float Health = 1.0f;
    public float Speed = 1.0f;
    public float Strength = 1.0f;
    public int LegCount = 2;

    public PowerUpBase PowerUp;

    public void UpdateHealth()
    {
        Health += PowerUp.PowerLevel;
    }

}
