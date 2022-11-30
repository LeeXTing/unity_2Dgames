using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOutline : MonoBehaviour
{
    private float outline = 30;
    private float outline2 = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > outline)
        {
            Destroy(gameObject);
        }
               
        else if (transform.position.z < -outline2)
        {
            Destroy(gameObject);
        }
    }
}
