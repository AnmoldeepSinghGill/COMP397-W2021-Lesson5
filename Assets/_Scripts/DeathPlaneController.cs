using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlaneController : MonoBehaviour
{
    public Transform spawnPoint;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // reference to the character controller of the player
            var controller = other.gameObject.GetComponent<CharacterController>();

            // turning controller on and off after changing the player position to spawn point
            controller.enabled = false;
            other.gameObject.transform.position = spawnPoint.position;
            controller.enabled = true;
        }
    }
}
