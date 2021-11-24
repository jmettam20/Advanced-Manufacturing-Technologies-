using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class settingsMenuHandle : MonoBehaviour
{
   
        public void openOptionsMenu()
        {
            SceneManager.LoadScene("Options");// load options menu 
        }
    
}
