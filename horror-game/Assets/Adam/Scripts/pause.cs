using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public GameObject Pausemenu;
    public  bool ispaused;
   

    public void playgame()
    {
        SceneManager.LoadScene("MainMenu");


    }
    void Start()
    {
        Pausemenu.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("dnjdnj");
            Pausemenu.SetActive(!Pausemenu.activeSelf);
            //Pausemenu.SetActive(true);
            if (Pausemenu.activeSelf == false)
            {
                Resumegame();
            }
            if(Pausemenu.activeSelf == true) 
            {
                pausegame();
            }
        }
    }
    public void pausegame()
    {
        Pausemenu.SetActive(true);
        Time.timeScale = 0f;
        ispaused = true;
    }
    public void Resumegame()
    {
        Pausemenu.SetActive(false);
        Time.timeScale = 1f;
        ispaused = false;
    }
}
