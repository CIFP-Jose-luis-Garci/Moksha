using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    [SerializeField] AudioClip general;
    [SerializeField] AudioClip niebla;
    [SerializeField] AudioClip templete;
    private AudioSource audioSource;
    private GameObject musicaNiebla;
    private GameObject musicaTemplete;
    bool generalcomp;
    bool templetecomp;
    bool nieblacomp;

    void Start()
    {
    
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(general, 2f);
        generalcomp = true;
        templetecomp = false;
        nieblacomp = false;
        
    }

    void Update()
    {
       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "MuroMusicaTemplete")
        {
            print("Ha pasado");
            if (generalcomp == true)
            {
                audioSource.Stop();
                audioSource.PlayOneShot(templete, 2f);
                generalcomp = false;
                templetecomp = true;
            }
            else
            {
                audioSource.Stop();
                audioSource.PlayOneShot(general, 2f);
                generalcomp = true;
                templetecomp = false;
            }
        }

        if (other.gameObject.name == "MuroMusicaNiebla")
        {
            if (generalcomp == true)
            {

            }
        }
    }

}
 