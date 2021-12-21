using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FusionRoundShoot : MonoBehaviour
{
    // Start is called before the first frame update
    public float bulletspeed = 10f;
    void Start()
    {
        Destroy(this.gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * bulletspeed * Time.deltaTime);
    }
}
