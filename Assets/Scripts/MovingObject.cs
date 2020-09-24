using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public Vector3 startPos, endPos;
    public float speed = 0.05f;
    private int direction = 1; // 1 = Right, -1 = Left

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * direction;

        if (Vector3.Distance(transform.position, startPos) < 0.1f)
        {
            direction = 1;
        }
        if (Vector3.Distance(transform.position, endPos) < 0.1f)
        {
            direction = -1;
        }
        
    }
}
