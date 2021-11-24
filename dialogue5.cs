using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogue5 : MonoBehaviour
{
    [SerializeField]
    public GameObject dilogue5;


    void OnTriggerEnter(Collider col)//if player triggers collider
    {
        dilogue5.SetActive(true);//turn on dialogue 5

    }
}
