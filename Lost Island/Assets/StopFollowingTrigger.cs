using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopFollowingTrigger : MonoBehaviour
{
    public FollowObject followObjectScript;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera")) 
        {
            Debug.Log("Trigger fired");
            followObjectScript.StopFollowing();
        }
    }
}
