using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrigger : MonoBehaviour
{
    public Spawner spawnerObj;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            spawnerObj.spawner.SetActive(true);
        }
    }
}
