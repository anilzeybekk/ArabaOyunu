using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunuDurdur : MonoBehaviour
{
    private bool isPaused = false; 
    private bool isGamePaused = false; 
    private AudioSource backgroundMusic;      AudioSource audioSource;

    void Start()
    {
       
        backgroundMusic = FindObjectOfType<AudioSource>();
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused)
            {
               
                SceneManager.LoadScene(0);
                isPaused = true;
            }
            else
            {
                
                SceneManager.LoadScene(1); 
                isPaused = false;
            }
        }

       
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!isGamePaused)
            {
                
                Time.timeScale = 0; 
                isGamePaused = true;

                
                if (backgroundMusic != null)
                {
                    backgroundMusic.Pause();
                }
            }
            else
            {
                
                Time.timeScale = 1;
                isGamePaused = false;

                
                if (backgroundMusic != null)
                {
                    backgroundMusic.Play();
                }
            }
        }
        
    }
}