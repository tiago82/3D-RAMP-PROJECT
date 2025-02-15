﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraPlayer : MonoBehaviour {

    public float dampTime = 0.15f;
    private Vector3 velocity = Vector3.zero;
    public Transform objetoParaSeguir;

    void Update() {
        Vector3 point = GetComponent<Camera>().WorldToViewportPoint(objetoParaSeguir.position);
        Vector3 delta = objetoParaSeguir.position - GetComponent<Camera>().ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
        Vector3 destination = transform.position + new Vector3(delta.x, delta.y, 0);
        
        transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
    }
}