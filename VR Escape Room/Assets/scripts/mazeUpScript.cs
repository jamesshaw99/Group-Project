using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mazeUpScript : MonoBehaviour
{

 
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "mazeController")
        {
            ballMovement.freezeBall = false;
            Debug.Log("up button is pressed");
            ballMovement.x = -5;
            ballMovement.y = 0;

        }
    }
    void OnCollisionExit(Collision col)
    {
        ballMovement.freezeBall = true;
    }
}
