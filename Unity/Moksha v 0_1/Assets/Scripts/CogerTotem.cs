using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogerTotem : MonoBehaviour
{
    [SerializeField] GameObject totem;
    [SerializeField] GameObject totemMesh;
    private MeshRenderer meshRendererTotem;
    [SerializeField] Transform personaje;
    private float dist;

    //Booleana que comprobará la niebla para comenzar a desaparecer
    public bool totemTaken;
    
    void Start()
    {
        meshRendererTotem = totemMesh.GetComponent<MeshRenderer>();
        meshRendererTotem.enabled = false;

        totemTaken = false;
    }

    // Update is called once per frame
    void Update()
    {
        cogerTotem();
    }
  
    void cogerTotem()
    {
        if (personaje)
        {
            dist = Vector3.Distance(personaje.position, transform.position);
            
        
          if (dist<2) 
            {
                if (Input.GetButtonDown("Accion"))
                {
                    meshRendererTotem.enabled = false;
                    //Cambiamos el valor que será leído por la niebla
                    totemTaken = true;
                }
            }  
        }
    }
}
