﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShotSound : MonoBehaviour
{
    public AudioSource soundGun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            soundGun.Play();
        }
    }
}
