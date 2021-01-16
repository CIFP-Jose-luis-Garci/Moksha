using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Vector3 distanciaCamara;
    private Transform target;
    [Range (0, 1)]public float lerp;
    public float sensibilidad;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Robot Kyle").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + distanciaCamara,  lerp);
        distanciaCamara = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * sensibilidad, Vector3.up) * distanciaCamara;
        transform.LookAt(target);
    }
}
 