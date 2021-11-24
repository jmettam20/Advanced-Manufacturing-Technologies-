using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerJump : MonoBehaviour
{
    public GameObject dilogue2;

    [SerializeField]
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>(); //get animator 
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")//if player collides 
        {

            anim.SetTrigger("Jump");
        }

    }
    
}
