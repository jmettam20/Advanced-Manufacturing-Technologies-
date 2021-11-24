using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenuScript : MonoBehaviour
{
    public static bool PAUSED = false; //bool to keep pause state 

    public GameObject pauseUI; //pause ui to be activated

   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) { //if ESC is pressed 
            if (PAUSED)//if already paused 
            {
                Resume();//resume 
            }
            else {
                Pause();//pause 
            }
        }
    }

   public void Resume() {
       
        pauseUI.SetActive(false);//turn pause menu off 
        Time.timeScale = 1f;///set time to normal 

        PAUSED = false; //set pause to false
    }

   public void Pause() {
        Cursor.visible = true; //show cursor 
        Screen.lockCursor = false; //unlock cursor 
        pauseUI.SetActive(true); //show pause menu 
        Time.timeScale = 0f; // stop time 

        PAUSED = true;  //set pasued to true 
    }


    public void Menu()
    {
        Time.timeScale = 1f; //set time to normal 
        SceneManager.LoadScene("Menu" ); // load menu 
    }

    public void QuitGame()
    {
        Application.Quit(); //quit game 
    }

    public void openOptionsMenu()
    {
        SceneManager.LoadScene("Options"); //load options menu 
    }
}
