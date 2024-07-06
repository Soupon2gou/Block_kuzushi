using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour
{
    public Vector2 speed = new Vector2(5f, 5f);
    Rigidbody2D rb;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
        rb.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Block"))
        {
            Destroy(other.gameObject);
        }
    }
}
