using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesKontrol : MonoBehaviour
{
    private AudioSource audioSource; 
    public AudioClip[] muzikler; 
    private int mevcutMuzikIndex = 0;

    void Start()
    {
        
        GameObject sesNesnesi = GameObject.FindWithTag("ses");
        if (sesNesnesi != null)
        {
            audioSource = sesNesnesi.GetComponent<AudioSource>();
        }
        else
        {
            Debug.LogError("Ses kaynağı bulunamadı! 'ses' etiketi atanmış bir nesne yok.");
        }
    }

    public void BirSonrakiMuzik()
    {
        if (audioSource != null && muzikler.Length > 0)
        {
            
            mevcutMuzikIndex = (mevcutMuzikIndex + 1) % muzikler.Length;
            audioSource.Stop();
            audioSource.clip = muzikler[mevcutMuzikIndex];
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("Müzik listesi boş veya AudioSource bulunamadı.");
        }
    }

    public void MuzikDegistir(int muzikIndex)
    {
        if (audioSource != null && muzikler.Length > muzikIndex)
        {
           
            audioSource.Stop();
            audioSource.clip = muzikler[muzikIndex];
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("Geçersiz müzik indeksi veya AudioSource bulunamadı.");
        }
    }

    public void MuzikDurdur()
    {
        
        if (audioSource.isPlaying)
        {
            audioSource.Pause(); 
        }
        else
        {
            audioSource.Play(); 
        }
    }
}