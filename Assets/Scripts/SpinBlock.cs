﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinBlock : MonoBehaviour {

    public float speed = 50f;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame

    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime, Space.World);
    }
}
