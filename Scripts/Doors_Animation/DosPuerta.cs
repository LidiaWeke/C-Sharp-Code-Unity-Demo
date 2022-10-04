using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class DosPuerta : MonoBehaviour
{
    public GameObject door;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AudioSource audio = GetComponent<AudioSource>();
            Destroy(gameObject, audio.clip.length);
            audio.Play();
            
            door.GetComponent<Animation>().Play("Puerta");
        }
    }

    
}