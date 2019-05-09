using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Interact : MonoBehaviour
{
    // Start is called before the first frame update
    public string interactButton;

    public float interactDistance = 3f;

    public LayerMask interactLayer;

    public Image interactIcon;

    public bool isInteracting;
    public GameObject videoPlayer;

    public int playTime;

    public GameObject finishTable;
    

    void Start()
    {
        videoPlayer.SetActive(false);
        finishTable.SetActive(true);
        
        if (interactIcon != null)
        {
        interactIcon.enabled = false;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.GetChild(0).position, transform.GetChild(0).forward);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, interactDistance, interactLayer))
        {
            if(isInteracting == false)
            {
                if(interactIcon!= null)
                {
                interactIcon.enabled = true;
                }
                
                if(hit.collider.CompareTag("Finish"))
                {
                    
                    videoPlayer.SetActive(true);
                    finishTable.SetActive(false);

                    Destroy(videoPlayer,playTime);

                }
                


                if(Input.GetButtonDown(interactButton))
                {
                    if(hit.collider.CompareTag("Note"))
                    {
                        hit.collider.GetComponent<Note>().ShowNoteImage();
        
                    }
                    if(hit.collider.CompareTag("Mark"))
                    {
                     
                            hit.collider.GetComponent<Markable>().changeTexture();
                   
                    }
                    if (hit.collider.CompareTag("DoorTrigger"))
                    {
                        hit.collider.GetComponent<DoorTrigger>().openDoor();
                    }

                }
            }
        }
        else
        {
            interactIcon.enabled = false;
        }
       
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

    }

   


}
