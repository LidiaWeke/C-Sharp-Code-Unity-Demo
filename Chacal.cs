using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chacal : MonoBehaviour
{
    public GameObject destroy;
    public GameObject sonido;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Chacal")
        {
            sonido.SetActive(true);
            destroy.SetActive(false);
            Destroy(other.gameObject);
        }
    }
}
