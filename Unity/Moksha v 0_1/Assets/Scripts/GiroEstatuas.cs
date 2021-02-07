using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiroEstatuas : MonoBehaviour
{
    [SerializeField] Transform personaje;
    private float dist;

    void Update()
    {
        rotacion();
       
    }
    void rotacion()
    {
        

        if (personaje)
            {
                 dist = Vector3.Distance(personaje.position, transform.position);
                //Debug.Log("Distancia al otro: " + dist);

                if (dist <= 4)
                {
                    if (Input.GetButtonDown("Accion"))
                    {
                    transform.Rotate(new Vector3(0,45,0));
                    //Debug.Log("Gira");
                    }
                }
            }
        //if (Posicion.transform.rotation == CorrectPos.transform.rotation)
        {
            //estatuaActiva = true;
            //Debug.Log("Opción Correcta");
        }

    }
    
}

     

