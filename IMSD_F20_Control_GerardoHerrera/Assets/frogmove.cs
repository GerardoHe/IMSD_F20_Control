﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frogmove : MonoBehaviour
{
    // Start is called before the first frame update

    float speed = 1.25f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
            transform.position += Vector3.up * speed;
        if (Input.GetKeyDown(KeyCode.S))
            transform.position += Vector3.down * speed;
    }
}
