using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public GameObject theMidroomDoor;
    public GameObject doorRoom1;
    public GameObject doorRoom2;
    public GameObject doorRoom3;
    public GameObject doorRoom4;
    Animator midAnimator;
    Animator room1Animator;
    Animator room2Animator;
    Animator room3Animator;
    Animator room4Animator;
    // Start is called before the first frame update
    void Start()
    {
        midAnimator = theMidroomDoor.GetComponent<Animator>();
        room1Animator = doorRoom1.GetComponent<Animator>();
        room2Animator = doorRoom2.GetComponent<Animator>();
        room3Animator = doorRoom3.GetComponent<Animator>();
        room4Animator = doorRoom4.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x < theMidroomDoor.transform.position.x + 5 && this.transform.position.x > theMidroomDoor.transform.position.x - 5)
        {
            midAnimator.SetBool("character_nearby", true);
        }
        else
        {
            midAnimator.SetBool("character_nearby", false);
        }

        if ((this.transform.position.z < doorRoom1.transform.position.z + 2 && this.transform.position.z > doorRoom1.transform.position.z - 2) && (-19 < this.transform.position.x && this.transform.position.x < -16))
        {
            room1Animator.SetBool("character_nearby", true);
        }
        else
        {
            room1Animator.SetBool("character_nearby", false);
        }

        if ((this.transform.position.z < doorRoom2.transform.position.z + 2 && this.transform.position.z > doorRoom2.transform.position.z - 2) && (-19 < this.transform.position.x && this.transform.position.x < -16))
        {
            room2Animator.SetBool("character_nearby", true);
        }
        else
        {
            room2Animator.SetBool("character_nearby", false);
        }

        if ((this.transform.position.z < doorRoom3.transform.position.z + 2 && this.transform.position.z > doorRoom3.transform.position.z - 2) && (-1 < this.transform.position.x && this.transform.position.x < 1))
        {
            room3Animator.SetBool("character_nearby", true);
        }
        else
        {
            room3Animator.SetBool("character_nearby", false);
        }

        if ((this.transform.position.z < doorRoom4.transform.position.z + 2 && this.transform.position.z > doorRoom4.transform.position.z - 2) && (-1 < this.transform.position.x && this.transform.position.x < 1))
        {
            room4Animator.SetBool("character_nearby", true);
        }
        else
        {
            room4Animator.SetBool("character_nearby", false);
        }
    }
}
