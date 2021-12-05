using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerStuff : MonoBehaviour
{
    // Here I created public GameObject slots you can use to drag and drop objects from the Hierarchy
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;


    //With this function I'm telling Unity to disable the objects when the Player enters inside the cube collider
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            object1.SetActive(false);
            object2.SetActive(false);
            object3.SetActive(false);
        }
    }


    //With this function I'm telling Unity to enable the objects when the Player get outside the cube collider
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            object1.SetActive(true);
            object2.SetActive(true);
            object3.SetActive(true);
        }
    }
}




