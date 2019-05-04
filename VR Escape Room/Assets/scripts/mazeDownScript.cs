using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mazeDownScript : MonoBehaviour
{
    public AudioSource audio;
    public float volume;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "downButton")
        {
            ballMovement.freezeBall = false;
            Debug.Log("down button is pressed");
            ballMovement.x = 5;
            ballMovement.y = 0;
            audio.Play();
        }
    }
    void OnCollisionExit(Collision col)
    {
        ballMovement.freezeBall = true;
    }
}
