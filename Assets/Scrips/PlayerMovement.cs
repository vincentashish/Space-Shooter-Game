using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 7f;
    public GameObject fusionRounds;
    public GameObject Missile;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Move_Hor = Input.GetAxisRaw("Horizontal");
        transform.Translate(Move_Hor * speed * Time.deltaTime, 0f, 0f);
        if(transform.position.x < -6.28f)
        {
            transform.position = new Vector3(6.28f, -3.87f, 0f);
        }
        if (transform.position.x > 6.28f)
        {
            transform.position = new Vector3(-6.28f, -3.87f, 0f);
        }
        if (Input.GetMouseButtonDown(0))
        {
            shootNow();
        }
        if (Input.GetMouseButtonDown(1))
        {
            MissileShoot();
        }
    }

    void shootNow()
    {
        Instantiate(fusionRounds, gameObject.transform.position, Quaternion.identity);
    }
    void MissileShoot()
    {
        Instantiate(Missile, gameObject.transform.position, Quaternion.identity);
    }
}
