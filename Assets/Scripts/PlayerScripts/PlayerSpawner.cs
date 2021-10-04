using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZObjectPools;

public class PlayerSpawner : MonoBehaviour
{
    public EZObjectPool myPool;
    public GameObject spawner;
    public GameObject pool;

    private float spawnTime = 0.1f;

    //private void Awake()
    //{
    //    spawner.SetActive(false);
    //    pool.SetActive(false);
    //}
    private void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnTime);
    }

    public void SpawnObject()
    {
     //   myPool.InstantiateOnAwake = true;
        spawner.SetActive(true);
        pool.SetActive(true);
        myPool.TryGetNextObject(transform.position, transform.rotation);       
    }

}
