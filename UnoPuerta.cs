using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class UnoPuerta : MonoBehaviour
{

    public GameObject door;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Babuino")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            door.GetComponent<Animation>().Play("Puerta");
        }
    }
}
