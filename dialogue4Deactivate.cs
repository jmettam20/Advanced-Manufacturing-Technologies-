using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogue4Deactivate : MonoBehaviour
{
    [SerializeField]
    public GameObject dilogue4deactivate;


    void OnTriggerEnter(Collider col)//if player collides
    {
        dilogue4deactivate.SetActive(false);//turn off trigger 4

    }
}
