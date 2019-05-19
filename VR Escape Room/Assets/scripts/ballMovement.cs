using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    public static int x;
    public static int y;
    public Rigidbody rb;
    public static bool freezeBall = false;
    private void Start()
    {
        rb.AddForce(0, 0, 0);
    }

    private void Update()
    {
        rb.isKinematic = false;
        rb.AddForce(y, 0, x);
        if(freezeBall == true)
        {
            rb.isKinematic = true;
        }
    }
}
