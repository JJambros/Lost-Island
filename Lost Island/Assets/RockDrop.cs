using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockDrop : MonoBehaviour
{
    public Transform spawnPoint;
    public Transform spawnPoint2;
    public GameObject confetti;
    public GameObject areaEffect;
    public GameObject sparkle;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Rock")) 
        {
            Instantiate(confetti, spawnPoint.position, spawnPoint.rotation);
            Instantiate(areaEffect, spawnPoint2.position, spawnPoint2.rotation);
            Instantiate(sparkle, spawnPoint.position, spawnPoint.rotation);
        }
    }
}

