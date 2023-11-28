using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class MoveLeft : MonoBehaviour
{
    public float speed = 0.01f;
    [SerializeField] private bool _isCloud = false;
    private Rigidbody2D _rb;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        if (_isCloud)
            transform.position = Vector2.MoveTowards(transform.position, transform.position - transform.right,
                Random.Range(3f, 5f) * Time.deltaTime);
        else
            transform.position = Vector2.MoveTowards(transform.position, transform.position - transform.right,
                speed * Time.deltaTime);

        if (transform.position.x <= -50)
            Destroy(gameObject);
    }

} 