﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMeteor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player")){
            Destroy(other.gameObject);
        }
    }
}