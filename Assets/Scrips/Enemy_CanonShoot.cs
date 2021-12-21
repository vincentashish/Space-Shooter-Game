﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_CanonShoot : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 3f;
    void Start()
    {
        Destroy(this.gameObject, 7f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
