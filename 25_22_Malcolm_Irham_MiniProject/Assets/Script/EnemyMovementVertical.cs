using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementVertical : MonoBehaviour
{
    public float MaxY;
    public float MinY;

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
            MoveUp();
        else if (direction == 1)
            MoveDown();
    }

    public void MoveUp()
    {
        transform.position += new Vector3(0, 1, 0) * Speed * Time.deltaTime;
        if (transform.position.y >= MaxY)
        {
            direction = 1;
        }
    }

    public void MoveDown()
    {
        transform.position += new Vector3(0, 1, 0) * -Speed * Time.deltaTime;
        if (transform.position.y <= MinY)
        {
            direction = 0;
        }
    }
}
