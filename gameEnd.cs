using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameEnd : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true;//make cursor visable 
        Screen.lockCursor = false;//unlock cursor
    }


    public void Menu()
    {
        SceneManager.LoadScene("Menu");//load menu 
    }

    public void QuitGame()
    {
        Application.Quit();//quit game 
    }
}
