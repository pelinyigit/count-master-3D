using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    ObjectPooler objectPooler;
    public GameObject targetPosition;
    public GameObject spawner;
    
    private void Start()
    {
        objectPooler = ObjectPooler.Instance;
       
    }

    void FixedUpdate()
    {

        objectPooler.SpawnFromPool("Player", targetPosition.transform.position, Quaternion.identity);
    }
}
