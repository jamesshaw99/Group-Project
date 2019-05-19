using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibilityButtonPress : MonoBehaviour
{
    public GameObject obj;
    public GameObject obj2;
    // Start is called before the first frame update
    void Start()
    {
        obj.SetActive(false);
        obj2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 0.7)
        {
            obj.SetActive(true);
            obj2.SetActive(true);
        }
    }
}
