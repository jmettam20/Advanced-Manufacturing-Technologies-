using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen : MonoBehaviour
{
    [SerializeField]
    GameObject door; //door 

    [SerializeField]
    public GameObject dilogue1; //dialogue box 1

    [SerializeField]
    public GameObject dilogue2; //dialogue box 2

    bool isOpened = false; //var tocheck if opened

    void OnTriggerEnter(Collider col) { //if player enters collider 
        if (!isOpened)//door is open 
        {
            dilogue1.SetActive(false);//turn off dialogue 1
            isOpened = true; //set door to open 
            door.transform.position += new Vector3(-2f, 0, 0);//move door 
            dilogue2.SetActive(true);//dialogue 2 appears 
        }
    }
   
}
