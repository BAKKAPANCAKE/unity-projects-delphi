using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public bool powerTime;
    Renderer meshrenderer;
    private Vector3 distance = new Vector3(5, 0, 0);
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        

            
               


                    if (powerTime)
                    {
            transform.position = transform.position + distance * Time.deltaTime;
                        if (transform.position.x >= 2)
                        {
                            powerTime = false;
                        }

                    }
                    else
                    {
                        transform.position = transform.position - distance*Time.deltaTime;
                        if (transform.position.x <= -2)
                        {
                            powerTime = true;
                        }
                    }

            

        
    }
}
