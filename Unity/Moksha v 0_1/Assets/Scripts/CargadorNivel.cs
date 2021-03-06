﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CargadorNivel : MonoBehaviour
{
    public GameObject PantallaDeCarga;
    public Slider Slider;
    void Start()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }

    }
    public void CargarNivel(int NumeroDeEscena)
    {
        StartCoroutine(CargarAsync(NumeroDeEscena));

    }
    IEnumerator CargarAsync(int NumeroDeEscena)
    {
       // AsyncOperation Operacion = SceneManager.LoadSceneAsync(NumeroDeEscena);

        PantallaDeCarga.SetActive(true);

        float Progreso = 0f;

        while (Progreso <=1)
        {
            Slider.value = Progreso;
            Progreso += 0.01f;
            
            if(Progreso > 0.99)
            {
                SceneManager.LoadSceneAsync(NumeroDeEscena);
            }
            
            
            yield return null;
        }

    }

    public void Opciones()
    {
        SceneManager.LoadScene("Menu_Opciones");
    }

    public void Info()
    {
        SceneManager.LoadScene("Menu_Info");
    }
    
    public void Salir()
    {
        Application.Quit();
    }


    /*
   IEnumerator CargarAsync(int NumeroDeEscena)
   {
       AsyncOperation Operacion = SceneManager.LoadSceneAsync(NumeroDeEscena);

       PantallaDeCarga.SetActive(true);

       while (!Operacion.isDone)
       {
           float Progreso = Mathf.Clamp01(Operacion.progress / .9f);
           Slider.value = Progreso;

           yield return null;
       }

   }
   */
}
