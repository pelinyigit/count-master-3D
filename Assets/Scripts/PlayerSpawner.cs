using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZObjectPools;

public class PlayerSpawner : MonoBehaviour
{
    public EZObjectPool myPool;

    private float spawnTime = 0.1f;

    private void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnTime);
    }

    void SpawnObject()
    {
        myPool.TryGetNextObject(transform.position, transform.rotation);
    }
}
