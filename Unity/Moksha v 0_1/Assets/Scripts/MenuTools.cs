using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuTools : MonoBehaviour
{

    Animator anim;
    [SerializeField] GameObject escafandra;

    bool menuHidden = true;

    //Flechas del mando
    float padArrows;

    //Array con los botones
    [SerializeField] Button[] botonesArray = new Button[6];
    int buttonSelected = 0;

    // Start is called before the first frame update
    void Start()
    {
        anim = GameObject.Find("MenuTools").GetComponent<Animator>();

        escafandra.SetActive(false);

        //Obtenemos los botones del menú y los metemos en el array
        //botonesArray = GameObject.Find("MenuTools").GetComponentsInChildren<Button>();
    }

    // Update is called once per frame
    void Update()
    {

        //Flechas del mando
        padArrows = Input.GetAxis("HerramientasNav");
        
        //Si pulsamos la tecla de herramientas
        if(Input.GetButtonDown("Herramientas"))
        {
            //Si el menú está oculto, lo mostramos
            if(menuHidden)
            {
                anim.SetTrigger("Show_menu");
                menuHidden = false;
                StartCoroutine("MenuNavigation");
            }
            else
            {
                anim.SetTrigger("Hide_menu");
                menuHidden = true;
                StopCoroutine("MenuNavigation");
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

    //Corrutina que comprueba cada segundo si estamos pulsando las felchas
    IEnumerator MenuNavigation()
    {
        //Seleccionamos el botón correspondiente
        botonesArray[buttonSelected].Select();

        while(true)
        {
            
            //print(padArrows);
            if(padArrows > 0.5f)
            {
                //Si no hemos llegado al último, seleccionamos el siguiente botón
                if(buttonSelected < 5)
                {
                    buttonSelected++;
                    botonesArray[buttonSelected].Select();
                    //print("derecha");
                }
                
            }
            else if(padArrows < -0.5f)
            {
                //Si no hemos llegado al último, seleccionamos el anterior botón
                if (buttonSelected > 0)
                {
                    buttonSelected--;
                    botonesArray[buttonSelected].Select();
                    //print("izquierda");
                }
            }
   
            yield return new WaitForSeconds(0.15f);
        }
    }
}
