using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileRoundShoot : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 3f;
    void Start()
    {
        Destroy(this.gameObject, 8f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
