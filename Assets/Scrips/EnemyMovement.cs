using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private float Enemy_speed = 3f;
    private float Move = 1;
    public GameObject Canon;
    private float bulletDelay = 3f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Fire", bulletDelay);
        bulletDelay += UnityEngine.Random.Range(2, 3);
        transform.Translate(Move * Enemy_speed * Time.deltaTime, 0f, 0f);
        if (transform.position.x < -5.5f || transform.position.x > 5.5f)
        {
            Move *= -1;
            Enemy_speed = UnityEngine.Random.Range(3f, 8f);
        }


    }


    void Fire()
    {
        Instantiate(Canon, gameObject.transform.position, Quaternion.identity);
    }
}