﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public Transform myTransform;

    public float speed;

    private float timer;

    //private void Update()
    // Start is called before the first frame update
    void Start()
    {
       // myTransform.position = new Vector3(0, Random.Range(0.0f, 1.0f), 0);
        myTransform.position = new Vector3(-10, myTransform.position.y, 0);
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //myTransform.position = 
       // myTransform.position = myTransform.position + new Vector3(1, 0, 0) * speed * Time.deltaTime;
        timer += Time.deltaTime;
        if (timer >= 0.050)
        {
            timer = 0;
            //myTransform.position += new Vector3(Random.Range(-1.00f, 2.00f), 0, 0) * speed;
            myTransform.position += new Vector3(1, 0, 0);
        }
    }
}