using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Note : MonoBehaviour
{
    public Image noteImage;
    public GameObject hideNoteButton;
    public GameObject playerObject;
    
    void Start()
    {
        noteImage.enabled = false;
        hideNoteButton.SetActive(false);
    }
    
    public void ShowNoteImage()
    {
      noteImage.enabled = true;
        hideNoteButton.SetActive(true);
        playerObject.SetActive(false);
        //playerObject.GetComponent<PlayerController>().enabled = false;
       
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        
    }

    public void HideNoteImage()
    {
        noteImage.enabled = false;
       hideNoteButton.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
       playerObject.SetActive(true);
      // playerObject.GetComponent<PlayerController>().enabled = true;
        
    }
}
