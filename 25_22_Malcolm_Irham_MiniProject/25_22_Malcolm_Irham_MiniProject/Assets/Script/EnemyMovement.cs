using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float MaxX;
    public float MinX;

    float Health = 3;

    float direction = 0;

    private float Speed = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (direction == 0)
            MoveForward();
        else if (direction == 1)
            MoveBackwards();
    }

    public void MoveForward()
    {
        transform.position += new Vector3(1, 0, 0) * Speed * Time.deltaTime;
        if (transform.position.x >= MaxX)
        {
            direction = 1;
        }
    }

    public void MoveBackwards()
    {
        transform.position += new Vector3(1, 0, 0) * -Speed * Time.deltaTime;
        if (transform.position.x <= MinX)
        {
            direction = 0;
        }
    }
}
