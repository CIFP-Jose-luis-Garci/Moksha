using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOpciones : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Menu_Inicio");
    }
}
