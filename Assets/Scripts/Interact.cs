﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    // Start is called before the first frame update
    public string interactButton;

    public float interactDistance = 3f;

    public LayerMask interactLayer;

    public Image interactIcon;

    public bool isInteracting;

    void Start()
    {
        if(interactIcon != null)
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
                

                if(Input.GetButtonDown(interactButton))
                {
                    if(hit.collider.CompareTag("Note"))
                    {
                        hit.collider.GetComponent<Note>().ShowNoteImage();
                    }
                   
                }
            }
        }
        else
        {
            interactIcon.enabled = false;
        }
       


    }

}
