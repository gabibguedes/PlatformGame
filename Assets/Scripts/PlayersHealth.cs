using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayersHealth : MonoBehaviour
{
    public int health = 200;
    public int enemyDamage = 50;

    public Text hpText;
    // Start is called before the first frame update
    void Start()
    {
     hpText.text = health.ToString();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Enemy")){
            health -= enemyDamage;
            hpText.text = health.ToString();
        }
    }
}
