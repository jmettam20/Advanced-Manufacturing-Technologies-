using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Menu : MonoBehaviour
{

    public string startGameScene; 
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;// make cursor visable 
        Screen.lockCursor = false;//unlock cursor 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        Time.timeScale = 1f;//set time to normal 
        SceneManager.LoadScene("SampleScene");//load factory level 
    }

    public void QuitGame()
    {
        Application.Quit(); //quit level 
    }

    public void openOptionsMenu()
    {
        SceneManager.LoadScene("Options"); //load options menu 
    }
}
