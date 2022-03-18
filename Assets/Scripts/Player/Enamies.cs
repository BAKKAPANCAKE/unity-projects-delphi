using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enamies : MonoBehaviour
{
    public GameObject lostCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovment>())
            lostCanvas.SetActive(true);

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerMovment>())
            Destroy(other.gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
