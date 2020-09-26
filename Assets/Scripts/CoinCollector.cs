using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    public Text coinText;
    // Start is called before the first frame update

    public int coins = 0;
    void Start()
    {
        coinText.text = coins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Coin")){
            coins ++;
            coinText.text = coins.ToString();
            Destroy(other.gameObject);
        }
    }
}
