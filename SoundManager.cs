using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource ado;

    void Start()
    {
        ado = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {        
        if(collision.gameObject.tag == "Slicable") 
        {
            ado.Play();
        }
    }
}
