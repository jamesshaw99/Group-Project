using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicControl : MonoBehaviour
{
    public Rigidbody rb;

    void Start()
    {
        transform.hasChanged = false;

        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    void Update()
    {
        if (transform.hasChanged)
        {
            rb.isKinematic = false;           
        }
    }

}
