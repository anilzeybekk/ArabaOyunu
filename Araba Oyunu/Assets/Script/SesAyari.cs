using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesAyari : MonoBehaviour
{
    private static SesAyari instance;
    private AudioSource audioSource; 

     void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
