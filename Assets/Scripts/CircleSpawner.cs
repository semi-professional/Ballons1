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
public class CircleSpawner : Factory<Circle>
{
    public AudioSource AS;
    public  AudioClip death;
    public  AudioClip coll;
    public void methodDeath()
    {

        AS.clip = death;
        AS.PlayOneShot(death);

    }
    public void methodColl()
    {
        AS.clip = coll;
        AS.PlayOneShot(coll);

    }

    [SerializeField] private int count;
    public float SpawnTime;
    


    private void Start()
    {
        AS = GetComponent<AudioSource>();
        GlobalEventManager.destroy += methodDeath;
        GlobalEventManager.gud_destroy += methodColl;
        InvokeRepeating("Respawn", 2, SpawnTime);

    }

     public void Respawn()
    {
       
            GetNewInstance();
      
    }
   
}        












