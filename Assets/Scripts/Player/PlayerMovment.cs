using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovment : MonoBehaviour
{
    public float movmentPower = 15;
    Rigidbody RB;
    public int score;
    public int coin = 0;
    public Vector3 plat;
       
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovment = Input.GetAxis("Horizontal") * movmentPower;
        Vector3 newMovment = RB.velocity;
        newMovment.x = horizontalMovment;
        RB.velocity = newMovment;
       int checkscore = Mathf.RoundToInt(transform.position.y * 100);
        if (checkscore > score)
        {
            score = checkscore;
        }
        






    }
    private void OnGUI()
    {

        GUI.Label(new Rect(10, 10, 100, 20), "coins:" + coin);
    }
   
}
