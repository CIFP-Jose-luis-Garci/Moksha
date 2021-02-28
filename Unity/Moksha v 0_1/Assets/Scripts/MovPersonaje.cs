using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovPersonaje : MonoBehaviour
{
    public float movHorizontal;
    public float movVertical;
    private Vector3 controlPersonaje;

    public CharacterController personaje;
    public float speed;
    private Vector3 movPersonaje;
    public float gravedad = 9.8f;
    public float velocidadCaida;

    public Camera camara;
    private Vector3 camForward;
    private Vector3 camRight;

    [SerializeField] Animator animator;
    bool agachado = false;
    // Start is called before the first frame update
    void Start()
    {
        personaje = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();

        DireccionCamara();
        PonerGravedad();
        Interactividad();
    }

    void Movimiento()
    {
        movHorizontal = Input.GetAxis("Horizontal");
        movVertical = Input.GetAxis("Vertical");

        controlPersonaje = new Vector3(movHorizontal, 0, movVertical);
        controlPersonaje = Vector3.ClampMagnitude(controlPersonaje, 1);

        
        animator.SetFloat("Caminar", controlPersonaje.magnitude * speed);
        personaje.Move(movPersonaje * Time.deltaTime);
    }
    void DireccionCamara()
    {
        camForward = camara.transform.forward;
        camRight = camara.transform.right;

        camForward.y = 0;
        camRight.y = 0;

        camForward = camForward.normalized;
        camRight = camRight.normalized;

        movPersonaje = controlPersonaje.x * camRight + controlPersonaje.z * camForward;
        movPersonaje = movPersonaje * speed;
        personaje.transform.LookAt(personaje.transform.position + movPersonaje);
    }
    void PonerGravedad()
    {
        if (personaje.isGrounded)
        {
            velocidadCaida = -gravedad * Time.deltaTime;
            movPersonaje.y = velocidadCaida;
        }
        else
        {
            velocidadCaida -= gravedad * Time.deltaTime;
            movPersonaje.y = velocidadCaida;
        }
    }
    void Interactividad()
    {
        if (Input.GetButtonDown("Agacharse"))
        {
            if (agachado == false)
            {
                animator.SetBool("Agacharse", true);
                agachado = true;
                speed = 1;
            }

            else
            {
                animator.SetBool("Agacharse", false);
                agachado = false;
                speed = 4.88f;
            }
        }
        else if (Input.GetButtonDown("Accion"))
        {
            animator.SetTrigger("Accion");
        }

        else if (Input.GetButtonDown("Pausa"))
        {
            SceneManager.LoadScene("Menu_Pausa");
        }

    }


}
