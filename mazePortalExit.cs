using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mazePortalExit : MonoBehaviour
{

    bool isTriggered = false; //portal isnt triggered 

    // Update is called once per frame


    void OnTriggerEnter(Collider col) //if player collides
    {
        if (!isTriggered) //if portal not triggered
        {
            isTriggered = true; //set trigger to true
            SceneManager.LoadScene("Factory");//load factory level 
        }
    }

}
