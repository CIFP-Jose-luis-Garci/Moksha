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

    [SerializeField] Transform gatoInitPos;
    [SerializeField] Transform gatoCorrectPos;

    [SerializeField] GameObject recompensa;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("RevCorrectPos");
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
            gatoInitPos.transform.rotation == gatoCorrectPos.transform.rotation)
        {
            Debug.Log("Opción Correcta");
            Instantiate(recompensa);
            StopCoroutine("RevCorrectPos");
        }
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
