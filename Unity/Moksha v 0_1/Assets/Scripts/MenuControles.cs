using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControles : MonoBehaviour
{
    public Canvas controles;

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            controles.enabled = false;

        }
    }
}
