using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Note : MonoBehaviour
{
    public Image noteImage;
    public GameObject hideNoteButton;
    public GameObject playerObject;
    //public GameObject cameraObject;
    // Start is called before the first frame update
    void Start()
    {
        noteImage.enabled = false;
        hideNoteButton.SetActive(false);

    }

    // Update is called once per frame
    public void ShowNoteImage()
    {
      noteImage.enabled = true;
        hideNoteButton.SetActive(true);
      playerObject.GetComponent<PlayerController>().enabled = false;
       // playerObject.GetComponent<camMouseLook>().enabled= false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        
    }

    public void HideNoteImage()
    {
        noteImage.enabled = false;
        hideNoteButton.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

       playerObject.GetComponent<PlayerController>().enabled = true;
        //playerObject.GetComponent<camMouseLook>().enabled = true;
    }
}
