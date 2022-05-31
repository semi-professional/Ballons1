using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Collections.ObjectModel;
using System;

public class Circle : MonoBehaviour
{
    
    
    
    
    float check;
    
    Rigidbody2D rb;
    CircleCollider2D col;
    public void Start()
    {
        
       
    }

  


    public void OnTriggerEnter2D(Collider2D collider)
    {
        Score.score--;
        GlobalEventManager.destroy();
        Destroy(gameObject);



    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (check < 1)
        {
            GlobalEventManager.gud_destroy();
            check++;
            GetComponent<Renderer>().material.color = Color.red;
           
        }
        else
        {



            GlobalEventManager.destroy();
            Score.score++;
            Destroy(gameObject);



        }
        
    }

    

}
