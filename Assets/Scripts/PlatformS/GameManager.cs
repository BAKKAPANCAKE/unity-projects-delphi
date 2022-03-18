using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Vector3 SpawnPosition;
    public GameObject PlatformPrefab;
    public Transform playerTransform;
    public GameObject player;
    public GameObject [] platforms;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <=5; i++)
        {
            createPlatform();
        }      
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.y > SpawnPosition.y - 15)
        {
            createPlatform();
        }
        
    }
    void createPlatform()
    {
        if (player.transform.position.y<20)
        {


            float randx = Random.Range(-2f, 3f);
            float randy = Random.Range(1.5f, 2);
            SpawnPosition.y += randy;
            SpawnPosition.x = randx;
            Instantiate(PlatformPrefab, SpawnPosition, Quaternion.identity);
        }
        if(player.transform.position.y>20 && player.transform.position.y < 50)
        {

            float randx = Random.Range(-2f, 3f);
            float randy = Random.Range(1.5f, 2);
            SpawnPosition.y += randy;
            SpawnPosition.x = randx;
            int pickPlat = Random.Range(0, platforms.Length);
            Instantiate(platforms[pickPlat], SpawnPosition, Quaternion.identity);
        }
    }
    
  
    
}
