using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class InvisibilityButtonPress : MonoBehaviour
{
    public GameObject obj;
    public GameObject obj2;
    public GameObject button;
    public GameObject leftHand;
    public GameObject rightHand;

    // Start is called before the first frame update
    void Start()
    {
        obj.SetActive(false);
        obj2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("left hand position" + leftHand.transform.position);
        Debug.Log("button position" + button.transform.position);
        if (leftHand.transform.position.x < button.transform.position.x + 1 && leftHand.transform.position.x > button.transform.position.x - 1  && leftHand.transform.position.y < button.transform.position.y + 1 && leftHand.transform.position.y > button.transform.position.y - 1 && leftHand.transform.position.z < button.transform.position.z + 1 && leftHand.transform.position.z > button.transform.position.z - 1)
        {        
            obj.SetActive(true);
            obj2.SetActive(true);
        }


    }
}
