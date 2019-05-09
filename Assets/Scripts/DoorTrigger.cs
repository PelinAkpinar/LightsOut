using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    AudioSource audioSource;
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openDoor()
    {
        door.SetActive(false);
        door.isStatic = false;
        audioSource.mute = true;
    }
}
