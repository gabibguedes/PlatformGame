using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;

    public float minPositionX = 0;
    public float maxPositionX = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.x >= minPositionX && player.transform.position.x <= maxPositionX){
            transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        }
        
    }
}
