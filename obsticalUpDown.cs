using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class obsticalUpDown : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")//if obj coll with player
        {
            SceneManager.LoadScene("Game Over", LoadSceneMode.Additive);//kill player 

        }

    }
}
