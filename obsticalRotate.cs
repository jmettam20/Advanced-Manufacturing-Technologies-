using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class obsticalRotate : MonoBehaviour
{
    public float speed = 35;//speed of rotation 
    public float stopspeed = 0;//stop speed 

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Jump Trigger")//if player collides 
        {
            transform.Rotate(Vector3.up, stopspeed * Time.deltaTime);//stop object rotation 
            SceneManager.LoadScene("Game Over", LoadSceneMode.Additive);//kill player 

        }

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime); //rotate object 
    }
}
