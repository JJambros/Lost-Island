using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockDrop : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Rock")) // Adjust the tag based on your setup
        {
            
        }
    }
}
