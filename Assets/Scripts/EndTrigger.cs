using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameObject videoPlayer;
    
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.SetActive(false);
    }

    // Update is called once per frame
   

    void OnTriggerEnter(Collider player)
    {
        if(videoPlayer.gameObject.tag=="Player")
        {
            videoPlayer.SetActive(true);
            Destroy(videoPlayer);

        }

    }
}
