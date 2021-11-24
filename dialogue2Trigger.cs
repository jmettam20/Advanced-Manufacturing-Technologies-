using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogue2Trigger : MonoBehaviour
{
 
    [SerializeField]
    public GameObject dilogue2;

  
    void OnTriggerEnter(Collider col)//if player enters trigger
    {
        dilogue2.SetActive(false); //get rid og dialogue 
        
    }
}
