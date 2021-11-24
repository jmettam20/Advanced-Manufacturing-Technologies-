using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogue3Trigger1 : MonoBehaviour
{
 
    [SerializeField]
    public GameObject dilogue3;

  
    void OnTriggerEnter(Collider col)//if player triggers collider
    {
        dilogue3.SetActive(false); //turn off dialogue3
        
    }
}
