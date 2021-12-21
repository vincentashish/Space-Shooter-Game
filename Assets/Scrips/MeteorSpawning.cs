using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawning : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Meteor;
    void Start()
    {
        InvokeRepeating("SpawnMeteor", 3f, 0.7f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnMeteor()
    {
        float RandXPos = Random.Range(-6.23f, 6.23f);
        Vector3 SpawnPos = new Vector3(RandXPos, transform.position.y, transform.position.z);
        Instantiate(Meteor, SpawnPos, Quaternion.identity);
    }
}
