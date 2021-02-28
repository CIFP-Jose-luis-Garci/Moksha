using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public Canvas pausa;
    public Canvas controles;

    void Start()
    {
        pausa.enabled = false;
        controles.enabled = false;
    }
    void Update()
    {
        if (Input.GetButtonDown("Pausa"))
        {
            if (pausa.enabled == false)
            {

                pausa.enabled = true;
                Time.timeScale = 0;
            }
            else if(pausa.enabled == true)
            {
                pausa.enabled = false;
                Time.timeScale = 1;
            }

            
        }
        /* con esto cerramos pausa con B, pero nos cierra todos los menus que haya abiertos
        if (Input.GetButtonDown("Cancel"))
        {
            if (pausa.enabled == true)
            {
                pausa.enabled = false;
                Time.timeScale = 1;
            }
        }
        */
    }
    
    public void PantallaIncio()
    {
        if (pausa.enabled == true)
        {
            SceneManager.LoadScene("Menu_Inicio");
        }
    }
    public void Controles()
    {
        controles.enabled = true;
    }
    
}

