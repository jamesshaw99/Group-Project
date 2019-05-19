using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mazeLeftControl : MonoBehaviour
{


    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "mazeController")
        {
            ballMovement.freezeBall = false;
            Debug.Log("left button is pressed");
            ballMovement.y = 5;
            ballMovement.x = 0;

        }
    }
    void OnCollisionExit(Collision col)
    {
        ballMovement.freezeBall = true;
    }
}
