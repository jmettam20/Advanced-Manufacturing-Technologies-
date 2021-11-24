using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true;// make cursor visable 
        Screen.lockCursor = false; //unlock sursor 
    }

    public void redo()
    {
        SceneManager.LoadScene("Maze");// load maze level 
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu"); //load menu 
    }

    public void QuitGame()
    {
        Application.Quit(); //quit game 
    }
}
