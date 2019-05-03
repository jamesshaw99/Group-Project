


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    //script needs to be added to every object we want to be able to pick up
    public Transform theDest;

    void OnMouseDown()
    {
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false; //turns gravity off so object doesnt just fall when pickedup
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("PickUpLocation").transform;
    }

    void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true; //turns gravity back on 
        GetComponent<BoxCollider>().enabled = true;
    }
}
