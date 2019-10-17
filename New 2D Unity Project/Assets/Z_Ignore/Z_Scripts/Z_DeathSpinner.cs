using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z_DeathSpinner : MonoBehaviour
{
    public float speed;
    public bool isClockwise;

    private void Start()
    {
        if (isClockwise)
        {
            speed = -speed;
        }
    }

    void Update()
    {
        transform.Rotate(Vector3.forward * speed);
    }
}
