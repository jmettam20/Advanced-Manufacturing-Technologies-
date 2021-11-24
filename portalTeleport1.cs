using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portalTeleport1 : MonoBehaviour
{

    bool isTrigger = false; //set trigger to false

    // Update is called once per frame

    
        void OnTriggerEnter(Collider col)//when player collides
        {
            if (!isTrigger)//if not triggered 
        {
            isTrigger = true;//set trigger to true
                SceneManager.LoadScene("Maze");//load maze level 
            }
        }
    
}
