using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humano : MonoBehaviour
{
    public GameObject destroy;
    public GameObject sonido;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Humano")
        {
            sonido.SetActive(true);
            destroy.SetActive(false);
            Destroy(other.gameObject);
        }
    }
}
