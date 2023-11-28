using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MoveToBeach : MonoBehaviour
{
    public Vector3 targetPosition;
    public float smoothTime = 0.5f;
    public float speed = 10;
    Vector3 velocity;

    public void toBeach()
    {

        
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime, speed);

        
    }

}
