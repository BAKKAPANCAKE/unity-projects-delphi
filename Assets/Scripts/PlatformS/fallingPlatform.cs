using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingPlatform : MonoBehaviour
{   bool isFalling = false;
    float downSpeed = 5;
    public Rigidbody rigidbody_component = null;
    public Collider platformCollider = null;
    private void OnTriggerEnter(Collider other)
    {
        {
            if (other.gameObject.GetComponent<PlayerMovment>())
            {
                isFalling = true;
                rigidbody_component.useGravity = isFalling;
            }
            if (other.gameObject.GetComponent<PlayerMovment>())
            {
                Destroy(other.gameObject);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isFalling)
        {
            downSpeed += Time.deltaTime;
            transform.position = new Vector3(transform.position.x, transform.position.y + downSpeed, transform.position.z);
            Debug.Log("hi");
        }
    }
}
