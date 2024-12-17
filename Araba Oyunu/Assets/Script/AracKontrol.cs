using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AracKontrol : MonoBehaviour
{
    bool oyunBitti = false;
    public int puan=0;

    public float speed = 10f;          
    public float turnSpeed = 50f;     
    AudioSource audioSource;

    void Update()
    {
        
        float moveInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * moveInput * speed * Time.deltaTime);

        
        if (moveInput != 0)
        {
            float turnInput = Input.GetAxis("Horizontal"); 
            transform.Rotate(Vector3.up * turnInput * turnSpeed * Time.deltaTime);
        }

        
        if (GetComponent<Rigidbody>().position.x <= -200)
        {
            oyunBitti = true;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            Invoke("restart", 2f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Engel")
        {
            Invoke("restart", 1f);
            audioSource.Play();
            
        }
        if(collision.collider.tag == "Coin")
        {
            puan++;
            Destroy(collision.gameObject);

        }
    }

    private void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Start()
    {
        puan=0;
        audioSource=GetComponent<AudioSource>();
    }
}

