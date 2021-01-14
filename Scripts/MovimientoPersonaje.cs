using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
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
    // Start is called before the first frame update
    void Start()
    {
        personaje = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        movHorizontal = Input.GetAxis("Horizontal");
        movVertical = Input.GetAxis("Vertical");

        controlPersonaje = new Vector3(movHorizontal, 0, movVertical);
        controlPersonaje = Vector3.ClampMagnitude(controlPersonaje, 1);

        direccionCamara();

        movPersonaje = controlPersonaje.x * camRight + controlPersonaje.z * camForward;
        movPersonaje = movPersonaje * speed;
        personaje.transform.LookAt(personaje.transform.position + movPersonaje);

        PonerGravedad();

        personaje.Move(movPersonaje * Time.deltaTime);
    }

    void direccionCamara()
    {
        camForward = camara.transform.forward;
        camRight = camara.transform.right;

        camForward.y = 0;
        camRight.y = 0;

        camForward = camForward.normalized;
        camRight = camRight.normalized; 
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
}
