using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstFuegoNiebla : MonoBehaviour
{
    [SerializeField] GameObject prefabLuz;
    [SerializeField] Vector3 PosLuz1;
    [SerializeField] Vector3 PosLuz2;
    [SerializeField] Vector3 PosLuz3;
    [SerializeField] Vector3 PosLuz4;
    [SerializeField] Vector3 PosLuz5;
    [SerializeField] Vector3 PosLuz6;
    [SerializeField] Vector3 PosLuz7;
    [SerializeField] Vector3 PosLuz8;
    [SerializeField] Vector3 PosLuz9;
    [SerializeField] Vector3 PosLuz10;
    [SerializeField] Vector3 PosLuz11;
    [SerializeField] Vector3 PosLuz12;
    [SerializeField] Vector3 PosLuz13;
    
    public GameObject totem;
    public MeshRenderer renderTotem;


    public int contador;
    // Start is called before the first frame update
    void Start()
    {
        totem = GameObject.Find("WaterTotem_A01");
        renderTotem = totem.GetComponent<MeshRenderer>();
        renderTotem.enabled = false;
        
        InstanciarLuz(PosLuz1);
        contador = 0;
    }

    public void InstanciarLuz(Vector3 NextPosVector)
    {
        transform.position = NextPosVector;
    }

    public void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.name == "Robot Kyle")
        {


            if (contador == 0)
            {
                InstanciarLuz(PosLuz2);
                contador++;

            }

            else if (contador == 1)
            {
                InstanciarLuz(PosLuz3);
                contador++;

            }

            else if (contador == 2)
            {
                InstanciarLuz(PosLuz4);
                contador++;

            }

            else if (contador == 3)
            {
                InstanciarLuz(PosLuz5);
                contador++;

            }

            else if (contador == 4)
            {
                InstanciarLuz(PosLuz6);
                contador++;
            }

            else if (contador == 5)
            {
                InstanciarLuz(PosLuz7);
                contador++;
            }

            else if (contador == 6)
            {
                InstanciarLuz(PosLuz8);
                contador++;
            }

            else if (contador == 7)
            {
                InstanciarLuz(PosLuz9);
                contador++;
            }

            else if (contador == 8)
            {
                InstanciarLuz(PosLuz10);
                contador++;
            }

            else if (contador == 9)
            {
                InstanciarLuz(PosLuz11);
                contador++;
            }

            else if (contador == 10)
            {
                InstanciarLuz(PosLuz12);
                contador++;
                //Aqui se va la ultima luz

                renderTotem.enabled = true;
            }

            

        }
        Debug.Log(contador);

    }

}
