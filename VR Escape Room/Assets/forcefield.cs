using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forcefield : MonoBehaviour

{
    public GameObject obj;

    void Start()
    {
        obj.SetActive(false);
        //torch = GameObject.Find("torch");
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "cell")
        {
            Debug.Log("HI");
            obj.SetActive(true);
            obj.GetComponent<Collider>().enabled = false;
        }
    }
    void OnCollisionExit(Collision col)
    {


    }
}