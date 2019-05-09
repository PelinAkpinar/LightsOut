using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PauseScript : MonoBehaviour
{
  
    string levelName = "Scene_Menu";
    public bool paused;
    
    // Start is called before the first frame update
    void Start()
    {
        paused = false;
       
      
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
        }
        if(paused)
        {
            
            SceneManager.LoadScene(levelName);
            // Cursor.lockState = CursorLockMode.None;
            //Cursor.visible = true;
            
        }
        
       
    }



}
