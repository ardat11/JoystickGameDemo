using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInnocent : MonoBehaviour
{   

    public static SpawnInnocent Instance;
    public GameObject MasumPrefab;

    
    public Vector3 alanMin;
    public Vector3 alanMax;
    private void Awake()
    {
        Instance = this;
    }


    public void Spawnit()

    {
        
        Vector3 rastgeleKonum = new Vector3(
            Random.Range(alanMin.x, alanMax.x),
            Random.Range(alanMin.y, alanMax.y),
            Random.Range(alanMin.z, alanMax.z)
        );

        
        Instantiate(MasumPrefab, rastgeleKonum, Quaternion.identity);
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Spawnit();
        }
    }





}
