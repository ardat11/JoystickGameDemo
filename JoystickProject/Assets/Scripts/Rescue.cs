using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rescue : MonoBehaviour
{
    public Transform LifeGuard;



    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Innocent"))
        {
            other.transform.parent = LifeGuard;
            //other.transform.position = new Vector3(0, 0.25f, -0.8f);
            //other.transform.rotation = Quaternion.Euler(24, 0, 0);
            PlayerController.Instance.speed = 10;


        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Beach") && LifeGuard.childCount == 3)
        {
            GameObject secondschild = LifeGuard.GetChild(2).gameObject;
            Destroy(secondschild);

            SpawnInnocent.Instance.Spawnit();
            ScoreManager.Instance.UpScore();
            PlayerController.Instance.speed = 15;


        }
    }


}
