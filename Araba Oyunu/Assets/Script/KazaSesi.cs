using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KazaSesi : MonoBehaviour
{
    public AudioClip crashSound; 
    private AudioSource audioSource;

    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.tag == "Engel")
        {
            
            audioSource.PlayOneShot(crashSound);
        }
    }
}