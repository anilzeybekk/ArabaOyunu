using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void basla()
    {
        SceneManager.LoadScene(1);
    }

    public void cikis()
    {
        Application.Quit();
    }

    public void TusAtamalari()
    {
        SceneManager.LoadScene(2);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
