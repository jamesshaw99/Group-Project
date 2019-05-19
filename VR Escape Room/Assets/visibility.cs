using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visibility : MonoBehaviour
{
    public GameObject obj;
    public GameObject torch;
    public Rigidbody rb;

    void Start()
    {
        obj.SetActive(false);
        //torch = GameObject.Find("torch");
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "torch")
        {
            obj.SetActive(true);
            obj.GetComponent<Collider>().enabled = false;
        }
    }
    void OnCollisionExit(Collision col)
    {


    }
}
