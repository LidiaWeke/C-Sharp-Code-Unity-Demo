using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Halcon : MonoBehaviour
{
    public GameObject destroy;
    public GameObject sonido;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Halcon")
        {
            sonido.SetActive(true);
            destroy.SetActive(false);
            Destroy(other.gameObject);
        }
    }
}
