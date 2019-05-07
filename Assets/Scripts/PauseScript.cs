using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PauseScript : MonoBehaviour
{
    GameObject pauseMenu;
    
    bool paused;
    
    // Start is called before the first frame update
    void Start()
    {
        paused = false;
        pauseMenu = GameObject.Find("pauseMenu");
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
        }
        if(paused==true)
        {
            
            pauseMenu.SetActive(true);
           
            Time.timeScale = 0;
            
        }
        else if (paused==false)
        {
            
            pauseMenu.SetActive(false);
           
            Time.timeScale = 1;
        }
       
    }

    public void Resume()
    {
        paused = false;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Scene_Menu");
    }

}
