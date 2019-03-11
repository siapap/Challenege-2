using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private bool dirRight = true;
    public float speed = 2.0f;

    //to set each enemy's position in unity
    public float pos1;
    public float pos2;

    void Update()
    {
        if (dirRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(-Vector2.right * speed * Time.deltaTime);
        }
            

        if (transform.position.x >= pos1)
        {
            dirRight = false;
        }
        else if (transform.position.x <= pos2)
        {
            dirRight = true;
        }

       
    }
}
