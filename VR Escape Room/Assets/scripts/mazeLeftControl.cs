using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mazeLeftControl : MonoBehaviour
{
    public AudioSource audio;
    public float volume;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "leftButton")
        {
            ballMovement.freezeBall = false;
            Debug.Log("left button is pressed");
            ballMovement.y = 5;
            ballMovement.x = 0;
            audio.Play();
        }
    }
    void OnCollisionExit(Collision col)
    {
        ballMovement.freezeBall = true;
    }
}
