using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuTools : MonoBehaviour
{

    Animator anim;
    [SerializeField] GameObject escafandra;

    bool menuHidden = true;

    // Start is called before the first frame update
    void Start()
    {
        anim = GameObject.Find("MenuTools").GetComponent<Animator>();

        escafandra.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Si pulsamos la tecla de herramientas
        if(Input.GetButtonDown("Herramientas"))
        {
            //Si el menú está oculto, lo mostramos
            if(menuHidden)
            {
                anim.SetTrigger("Show_menu");
                menuHidden = false;
                
            }
            else
            {
                anim.SetTrigger("Hide_menu");
                menuHidden = true;
            }
        }
    }

    public void PonerEscafandra()
    {
        //Si no lleva la escafandra, se la ponemos, y al revés
        if(escafandra.activeSelf == false)
        {
            escafandra.SetActive(true);
        }
        else
        {
            escafandra.SetActive(false);
        }
        
    }
}
