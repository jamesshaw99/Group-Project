using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mazeRightControl : MonoBehaviour
{
    public AudioSource audio;
    public float volume;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "rightButton")
        {
            ballMovement.freezeBall = false;
            Debug.Log("right button is pressed");
            ballMovement.y = -5;
            ballMovement.x = 0;
            audio.Play();
        }
    }
    void OnCollisionExit(Collision col)
    {
        ballMovement.freezeBall = true;
    }
}
