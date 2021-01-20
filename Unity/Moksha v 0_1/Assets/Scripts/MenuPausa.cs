using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public void PantallaIncio ()
    {
        SceneManager.LoadScene("Menu_Inicio");
    }
    public void Controles()
    {
        SceneManager.LoadScene("Menu_Controles");
    }

    public void Play ()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

