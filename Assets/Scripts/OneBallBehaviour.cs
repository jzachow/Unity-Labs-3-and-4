﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneBallBehaviour : MonoBehaviour
{
    static int ballCount = 0;
    public float XRotation = 0;
    public float YRotation = 1;
    public float ZRotation = 0;
    public float DegressPerSecond = 180;
    public int BallNumber;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(3 - Random.value * 6, 3 - Random.value * 6, 3 - Random.value * 6);
        ballCount++;
        ballNumber = ballCount;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 axis = new Vector3(XRotation, YRotation, ZRotation);
        transform.RotateAround(Vector3.zero, axis, DegressPerSecond * Time.deltaTime);
    }
}
