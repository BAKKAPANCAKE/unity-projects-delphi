using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionControll : MonoBehaviour
{
    public Vector3 newpos;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(5f, 4f, 3f);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = newpos;
    }
}
