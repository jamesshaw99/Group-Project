using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mazeRightControl : MonoBehaviour
{


    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "rightButton")
        {
            ballMovement.freezeBall = false;
            Debug.Log("right button is pressed");
            ballMovement.y = -5;
            ballMovement.x = 0;

        }
    }
    void OnCollisionExit(Collision col)
    {
        ballMovement.freezeBall = true;
    }
}
