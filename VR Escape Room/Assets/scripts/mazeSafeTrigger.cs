using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mazeSafeTrigger : MonoBehaviour
{
    public AudioSource audio;
    public float volume;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
        GameObject safeDoor = GameObject.Find("safeDoor");
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "mazeEnd")
        {
            Debug.Log("the safe opens");
            safeDoor.doorOpen = true;
            audio.Play();
        }
    }
}
