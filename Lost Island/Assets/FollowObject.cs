using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform target; // Reference to the moving object
    private bool isFollowing = true;
    void Update()
    {
        if (isFollowing && target != null)
        {
            // Adjust the camera's position based on the moving object's position
            transform.position = target.position + new Vector3(0, 2, 0); // Adjust these values as needed
        }
    }

    public void StopFollowing()
    {
        isFollowing = false;
    }
}
