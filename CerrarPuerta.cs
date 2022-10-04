using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CerrarPuerta : MonoBehaviour
{

    public GameObject door;

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            door.GetComponent<Animation>().Play("Door");
        }
    }
}
