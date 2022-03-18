using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPicker : MonoBehaviour
{
    public GameObject[] itemsToPick;
    public int randomIndex;
    // Start is called before the first frame update
    void Start()
    {
        pick();
    }

    void pick()

    {
        randomIndex = Random.Range(0, itemsToPick.Length);
        GameObject clone = Instantiate(itemsToPick[randomIndex], transform.position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
