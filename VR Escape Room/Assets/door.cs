using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public GameObject theDoor;
    Animator otherAnimator;
    // Start is called before the first frame update
    void Start()
    {
        otherAnimator = theDoor.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x < theDoor.transform.position.x + 5 && this.transform.position.x > theDoor.transform.position.x - 5)
        {
            otherAnimator.SetBool("character_nearby", true);
        }
        else
        {
            otherAnimator.SetBool("character_nearby", false);
        }
    }
}
