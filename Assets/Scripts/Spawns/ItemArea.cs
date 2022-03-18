using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemArea : MonoBehaviour
{
    public GameObject itemsToSpread;
    public int numItemsToSpread = 10;
    public bool check;

    public float itemXspread = 10f;
    public float itemYspread = 0f;
    public float itemZspread = 10f;
    // Start is called before the first frame update

    void spreadItem()
    {
        Vector3 randPos = new Vector3(Random.Range(-itemXspread, itemXspread), Random.Range(-itemYspread, itemYspread), Random.Range(-itemZspread, itemZspread));
        GameObject clone = Instantiate(itemsToSpread, randPos + transform.position, Quaternion.identity);
    }

    void Start()
    {
        for (int i = 0; i < numItemsToSpread && check; i++)
            spreadItem();
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
