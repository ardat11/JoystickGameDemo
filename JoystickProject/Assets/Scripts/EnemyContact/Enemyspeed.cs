using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspeed : MonoBehaviour
{
    public Rigidbody rb;

    public float speed;

    private void Update()
    {
        rb.velocity = new Vector3(speed,0,0);   



    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Limit"))
        {
            speed *= -1;


        }
    }








}
