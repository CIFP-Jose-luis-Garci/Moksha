using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstruPedestal : MonoBehaviour
{
    [SerializeField] Transform personaje;
    private float dist;
    [SerializeField] Canvas instru;

    // Start is called before the first frame update
    void Start()
    {
        instru.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Robot Kyle")
        {
            print("pulsado");
            if (Input.GetKeyDown("space"))
            {
                print("boton");
                if (instru.enabled == false)
                {
                    instru.enabled = true;
                    Time.timeScale = 1;
                }

            }

            else if (Input.GetButtonDown("Cancel"))
            {
                if (instru.enabled == true)
                {
                    instru.enabled = false;
                    Time.timeScale = 0;
                }
            }

        }
    }
  
}
