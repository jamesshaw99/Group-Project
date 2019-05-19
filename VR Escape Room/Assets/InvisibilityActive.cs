using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibilityActive: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "hexagonTrophie")
        {
            Debug.Log("YO");
        }
    }
}
