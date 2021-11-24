using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogue4 : MonoBehaviour
{

    [SerializeField]
    public GameObject dilogue4;


    void OnTriggerEnter(Collider col)//if player collides 
    {
        dilogue4.SetActive(true);//turn on dialogue 4

    }
}
