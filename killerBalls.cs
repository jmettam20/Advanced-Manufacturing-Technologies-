using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killerBalls : MonoBehaviour
{

    bool ballTouch = false;

    // Update is called once per frame


    void OnTriggerEnter(Collider col)
    {
        if (!ballTouch)
        {
            ballTouch = true;
            SceneManager.LoadScene("Menu", LoadSceneMode.Additive);
        }
    }

}