using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayStats : MonoBehaviour
{
    public Text scoreText;
    public PlayerMovment PM;
    public Text highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = "high score:"+PlayerPrefs.GetInt("HS").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text ="score:"+ PM.score.ToString();
    }
}
