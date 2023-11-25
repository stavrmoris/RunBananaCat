using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class MoveLeft : MonoBehaviour
{
    [FormerlySerializedAs("Speed")] public float speed = 0.01f;
    public Rigidbody2D rb;


    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void Update() 
    {
        transform.position = Vector2.MoveTowards(transform.position, transform.position - transform.right, speed);

        if(transform.position.x <= -13)
            Destroy(gameObject);
    }
 } 