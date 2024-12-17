using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KronometreHedef : MonoBehaviour
{
    
    public TextMeshProUGUI kronometreText; 
    private float zaman; 
    private bool calisiyor; 

    public Transform oyuncu; 
    public float hedefX = -200f; 

    // Start is called before the first frame update
    void Start()
    {
        zaman = 0f; 
        calisiyor = true; 
    }

    // Update is called once per frame
    void Update()
    {
       if (calisiyor)
        {
           
            zaman += Time.deltaTime;
            kronometreText.text = FormatZaman(zaman);
        }


        if (oyuncu.position.x <= hedefX)
        {
            KronometreyiDurdur();
        }
    }

    public void KronometreyiDurdur()
    {
        calisiyor = false;
        Debug.Log("Hedefe ulaşıldı! Toplam süre: " + FormatZaman(zaman));
    }

    private string FormatZaman(float zaman)
    {
        int dakika = Mathf.FloorToInt(zaman / 60F);
        int saniye = Mathf.FloorToInt(zaman % 60F);
        int salise = Mathf.FloorToInt((zaman * 1000) % 1000);
        return dakika.ToString("00") + ":" + saniye.ToString("00") + ":" + salise.ToString("000");
    
    }
}
