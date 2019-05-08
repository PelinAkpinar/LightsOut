using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Markable : MonoBehaviour
{
    
    Renderer rend;
    public Texture2D materialNew;
    public Texture2D materialOld;
    // Start is called before the first frame update
    void Start()
    {

        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial.mainTexture = materialOld;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeTexture()
    {
        if(this.rend.material.mainTexture!= materialNew)
        {
        this.rend.material.mainTexture= materialNew;
          
           
        }
        else if (this.rend.material.mainTexture == materialNew)
        {
            this.rend.material.mainTexture = materialOld;
            
         
        }
    }
}
