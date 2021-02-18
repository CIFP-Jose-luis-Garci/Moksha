using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecEstatuaInstanciador : MonoBehaviour
{
    [SerializeField] Transform leonInitPos;
    [SerializeField] Transform leonCorrectPos;

    [SerializeField] Transform guerreroInitPos;
    [SerializeField] Transform guerreroCorrectPos;

    [SerializeField] Transform monjeInitPos;
    [SerializeField] Transform monjeCorrectPos;

    [SerializeField] Transform ciervoInitPos;
    [SerializeField] Transform ciervoCorrectPos;

    [SerializeField] GameObject recompensa;
    [SerializeField] Vector3 VectorTotemEstatuas;
    private Transform PosTotemEstatuas;

    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("RevCorrectPos");
        PosTotemEstatuas.position = VectorTotemEstatuas;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InstanciarRecompensa()
    {
        if (leonInitPos.transform.rotation==leonCorrectPos.transform.rotation &&
            guerreroInitPos.transform.rotation == guerreroCorrectPos.transform.rotation && 
            monjeInitPos.transform.rotation == monjeCorrectPos.transform.rotation && 
            ciervoInitPos.transform.rotation == ciervoCorrectPos.transform.rotation)
        {
            Debug.Log("Opción Correcta");
            Instantiate(recompensa, PosTotemEstatuas);
            StopCoroutine("RevCorrectPos");
        }

        /*if (leonInitPos.transform.rotation == leonCorrectPos.transform.rotation)
        {
            Debug.Log("Leon");
        }
        if (guerreroInitPos.transform.rotation == guerreroCorrectPos.transform.rotation)
        {
            Debug.Log("Guerrero");
        }
        if (monjeInitPos.transform.rotation == monjeCorrectPos.transform.rotation)
        {
            Debug.Log("Monje");
        }
        if (ciervoInitPos.transform.rotation == ciervoCorrectPos.transform.rotation)
        {
            Debug.Log("Ciervo");
        }*/
    }
    IEnumerator RevCorrectPos()
    {
        for (; ; )
        {
            InstanciarRecompensa();
            yield return new WaitForSeconds(1f);
        }
    }




}
