using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWalls : MonoBehaviour
{

    public float Up, Down, Speed;


    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > Up)
        {
            transform.position = new Vector3(transform.position.x,Up, 0);
            Speed = -Speed;
        }
        else if (transform.position.y < Down)
        {
            transform.position = new Vector3(transform.position.x,Down, 0);
            Speed = -Speed;
        }

        transform.position += new Vector3(0, Speed * Time.deltaTime, 0);
    }
}
