using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VasosCanopos : MonoBehaviour
{
    public GameObject manoPunto;
    private GameObject recogerObjeto = null;

    void Update()
    {
        if(recogerObjeto!=null)
        {
            if(Input.GetKey("r"))
            {
                recogerObjeto.GetComponent<Rigidbody>().useGravity = true;

                recogerObjeto.GetComponent<Rigidbody>().isKinematic = false;

                recogerObjeto.gameObject.transform.SetParent(null);

                recogerObjeto = null;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag ("Halcon"))
        {
            if (Input.GetKey("e")&& recogerObjeto == null)
            {
                other.GetComponent<Rigidbody>().useGravity = false;

                other.GetComponent<Rigidbody>().isKinematic = true;

                other.transform.position = manoPunto.transform.position;

                other.gameObject.transform.SetParent(manoPunto.gameObject.transform);

                recogerObjeto = other.gameObject;
            }
        }
        if (other.gameObject.CompareTag ("Humano"))
        {
            if (Input.GetKey("e") && recogerObjeto == null)
            {
                other.GetComponent<Rigidbody>().useGravity = false;

                other.GetComponent<Rigidbody>().isKinematic = true;

                other.transform.position = manoPunto.transform.position;

                other.gameObject.transform.SetParent(manoPunto.gameObject.transform);

                recogerObjeto = other.gameObject;
            }
        }
        if (other.gameObject.CompareTag ("Chacal"))
        {
            if (Input.GetKey("e") && recogerObjeto == null)
            {
                other.GetComponent<Rigidbody>().useGravity = false;

                other.GetComponent<Rigidbody>().isKinematic = true;

                other.transform.position = manoPunto.transform.position;

                other.gameObject.transform.SetParent(manoPunto.gameObject.transform);

                recogerObjeto = other.gameObject;
            }
        }
        if (other.gameObject.CompareTag ("Babuino"))
        {
            if (Input.GetKey("e") && recogerObjeto == null)
            {
                other.GetComponent<Rigidbody>().useGravity = false;

                other.GetComponent<Rigidbody>().isKinematic = true;

                other.transform.position = manoPunto.transform.position;

                other.gameObject.transform.SetParent(manoPunto.gameObject.transform);

                recogerObjeto = other.gameObject;
            }
        }
    }

}
