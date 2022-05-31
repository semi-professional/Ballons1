using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    int h;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }
   
    
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(h, 0)*speed;
       
    }
    
   
}
