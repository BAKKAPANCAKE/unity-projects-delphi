using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    [Range(5,20)]
    public float JumpForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovment>())
        {
            Rigidbody RB = other.GetComponent<Rigidbody>();
            if (RB.velocity.y < 0)
            {
                Vector3 newVelocity = RB.velocity;
                newVelocity.y = JumpForce;
                RB.velocity = newVelocity;
            }

            
        }
    }
}
