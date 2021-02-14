using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuMapa : MonoBehaviour
{
    public GameObject mapa;
    bool openMapa;

    // Start is called before the first frame update
    void Start()
    {
        openMapa = false;
        mapa.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        MostrarMapa();
    }
    void MostrarMapa()
    {
        
        if (Input.GetButtonDown("BMapa"))
        {
            if (openMapa == false)
            {
                mapa.SetActive(true);
                Time.timeScale = 0;
                openMapa = true;
            }
            else
            {
                mapa.SetActive(false);
                Time.timeScale = 1;
                openMapa = false;
            }
            
        }
    }
}
