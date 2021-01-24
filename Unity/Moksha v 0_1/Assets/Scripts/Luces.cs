using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luces : MonoBehaviour
{
    [SerializeField] GameObject prefabLuz;
    [SerializeField] GameObject totem;
    [SerializeField] Transform InitPos;
    private Transform OrigenPos;
    private Vector3 RandomPos;
    private float randomNumber1;
    private float randomNumber2;
    public int contador;
    // Start is called before the first frame update
    void Start()
    {
        InstanciarLuz();
        contador = 1;
    }

    public void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.name == "Robot Kyle")
        {
            if (contador <= 2)
            {
                contador++;
                InstanciarLuz();
                

            }
            else if (contador == 3)
            {
                contador++;
                InstanciarTotem();
            }
        }
        Debug.Log(contador);
    }
    void InstanciarLuz()
    {
       randomNumber1 = Random.Range(-13f, 13f);
       randomNumber2 = Random.Range(-13f, 13f);
       RandomPos = new Vector3(randomNumber1, 0, randomNumber2);
       InitPos.transform.position = RandomPos;

           Instantiate(prefabLuz, InitPos);    
    }
    void InstanciarTotem()
    {
        Instantiate(totem, OrigenPos);
    }
        
    
}

