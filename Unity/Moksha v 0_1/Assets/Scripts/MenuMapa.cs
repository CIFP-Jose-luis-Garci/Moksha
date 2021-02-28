using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuMapa : MonoBehaviour
{
    public Canvas mapa;

    // Start is called before the first frame update
    void Start()
    {
        mapa.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("BMapa"))
        {
          if (mapa.enabled == true)
          {
               mapa.enabled = false;
               Time.timeScale = 1;
          }

          else if (mapa.enabled == false)
          {
               mapa.enabled = true;
               Time.timeScale = 0;
          }
        }
    }
   

}
