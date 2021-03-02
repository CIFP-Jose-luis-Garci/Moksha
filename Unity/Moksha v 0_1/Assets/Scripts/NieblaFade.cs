using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NieblaFade : MonoBehaviour
{
    private ParticleSystemRenderer psr;
    public float maxSize;

    //El totem
    CogerTotem totem;
    bool fadeActivado;

    // Start is called before the first frame update
    void Awake()
    {
        psr = GetComponent<ParticleSystemRenderer>();
        maxSize = 0.5f;

        fadeActivado = false;
        //Accedemos al script del totem para ver si ha sido cogido
        totem = GameObject.Find("totem_niebla").GetComponent<CogerTotem>();
    }

    // Update is called once per frame
    void Update()
    {
        //Si cambia el booleano del totem, y es la primera vez
        if (totem.totemTaken == true && fadeActivado == false)
        {
            StartCoroutine("FadeFog");
            fadeActivado = true;
        }
    }

    IEnumerator FadeFog()
    {
        while (maxSize >= 0.02f)
        {
            maxSize -= 0.01f;
            psr.maxParticleSize = maxSize;
            print("desvaneciendo" + gameObject.name);
            yield return new WaitForSeconds(0.1f);
        }

    }
}
