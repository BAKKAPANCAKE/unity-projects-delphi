using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    public GameObject lostCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlatformScript>())
            Destroy(other.gameObject);
        if (other.GetComponent<PlatformMove>())
            Destroy(other.gameObject);
        if (other.GetComponent<Enamies>())
            Destroy(other.gameObject);

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerMovment>())
        {
            lostCanvas.SetActive(true);
            int endScore= other.GetComponent<PlayerMovment>().score;
            if (endScore > PlayerPrefs.GetInt("HS"))
            {
                PlayerPrefs.SetInt("HS", endScore);
            }
        }
        if (lostCanvas)
        {
          
        }
           
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
