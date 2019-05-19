using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class safeDoor : MonoBehaviour
{
    public static bool doorOpen = false; 
    void Start()
    {
        
    }

    void Update()
    {
        if (doorOpen == true)
        {
            Destroy(gameObject);
        }
    }
}
