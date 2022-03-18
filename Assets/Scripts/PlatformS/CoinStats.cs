using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinStats : MonoBehaviour
{
    public Text coinText;
    public PlayerMovment PLM;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        coinText.text = "coins:" + PLM.coin.ToString();
    }
    
        
    
}
