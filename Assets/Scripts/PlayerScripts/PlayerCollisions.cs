using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {  
            gameObject.SetActive(false);
            other.gameObject.SetActive(false);

        } else if (other.tag == "Obstacle")
        {
            gameObject.SetActive(false);
        }
    }
}
