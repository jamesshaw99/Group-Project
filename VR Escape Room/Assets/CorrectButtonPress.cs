using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectButtonPress : MonoBehaviour
{
    public GameObject xCoordOnScreen;
    public GameObject yCoordOnScreen;
    public GameObject finalResult;
    public GameObject error;
    public AudioSource BGM;
    bool x = false;
    bool y = false;
    void Start()
    {
        xCoordOnScreen.SetActive(false);
        yCoordOnScreen.SetActive(false);
        finalResult.SetActive(false);
        error.SetActive(false);

    }

    private void Update()
    {
        
    }
    IEnumerator OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "x2")
        {
            xCoordOnScreen.SetActive(true);
            x = true;
        }
        else if (collisionInfo.collider.name == "y4")
        {
            yCoordOnScreen.SetActive(true);
            y = true;
        }
        if (x & y)
        {
            finalResult.SetActive(true);
            BGM.Play();
        }
        else
        {
            error.SetActive(true);
            yield return new WaitForSeconds(2);
            error.SetActive(false);
            yield return new WaitForSeconds(2);
            error.SetActive(true);
            yield return new WaitForSeconds(2);
            error.SetActive(false);


        }
    }
    
}
