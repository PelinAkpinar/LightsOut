using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Note : MonoBehaviour
{
    public AudioClip pickUp;
    public AudioClip putDown;
    public Image noteImage;
    public GameObject hideNoteButton;
    public GameObject noteObject;
    public GameObject cameraObject;

    void Start()
    {
        noteImage.enabled = false;
        hideNoteButton.SetActive(false);
    }
    
    public void ShowNoteImage()
    {
       GetComponent<AudioSource>().PlayOneShot(pickUp);
       noteImage.enabled = true;
       
       hideNoteButton.SetActive(true);
       //cameraObject.SetActive(false);
      
       
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        
        
    }

    public void HideNoteImage()
    {
       
       
        noteImage.enabled = false;
        GetComponent<AudioSource>().PlayOneShot(putDown);
        hideNoteButton.SetActive(false);
       // cameraObject.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
        noteObject.SetActive(false);
       
      // playerObject.GetComponent<PlayerController>().enabled = true;
        
    }
}
