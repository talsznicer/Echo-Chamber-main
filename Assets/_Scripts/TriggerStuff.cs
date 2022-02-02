using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerStuff : MonoBehaviour
{
    // Here I created public GameObject slots you can use to drag and drop objects from the Hierarchy
    public GameObject objectOn;
    public GameObject objectOff;
    //public GameObject object3;


    //With this function I'm telling Unity to disable the objects when the Player enters inside the cube collider
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            objectOn.SetActive(true);
            objectOff.SetActive(false);
            //object3.SetActive(true);
        }
    }


    //With this function I'm telling Unity to enable the objects when the Player get outside the cube collider
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            objectOn.SetActive(false);
            objectOff.SetActive(true);
            //object3.SetActive(false);
        }
    }
}




