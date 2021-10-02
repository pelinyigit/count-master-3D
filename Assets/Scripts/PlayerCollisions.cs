using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);

        } else if (other.tag == "Obstacle")
        {
            Destroy(this.gameObject);
        }
    }
}
