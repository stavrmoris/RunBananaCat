using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundAnimation : MonoBehaviour
{
    public float speed = 0.01f;
    
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, transform.position - transform.right,
                        speed * Time.deltaTime);

        if (transform.position.x <= -6.4f)
            transform.position = new Vector2(0f, transform.position.y);
    }
}
