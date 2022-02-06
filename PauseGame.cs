using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    // Creating a pause menu in game.
    public bool gamePaused = false;
    public AudioSource LevelMusic;
    public GameObject pauseMenu;

    // These are the function that will play out if you select any of these buttons. 
    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            if(gamePaused == false)
            {
                Time.timeScale = 0;
                gamePaused = true;
                Cursor.visible = true;
                LevelMusic.Pause();
                pauseMenu.SetActive(true);
            }
            else
            {
                pauseMenu.SetActive(false);
                LevelMusic.UnPause();
                Cursor.visible = false;
                gamePaused = false;
                Time.timeScale = 1;
            }
        }
    }

    // Resume fuction will resume the game.
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        LevelMusic.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
    }
    
    // Restart Level function will restart the current level.
    public void RestartLevel()
    {
        pauseMenu.SetActive(false);
        LevelMusic.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }

    // Quit to menu function will take you to the main menu.
    public void QuitToMenu()
    {
        pauseMenu.SetActive(false);
        LevelMusic.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

}
