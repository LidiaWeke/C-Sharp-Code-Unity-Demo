using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcertijoPanel : MonoBehaviour
{
    public GameObject uiObject;
    private bool menuOn;

    private void Start()
    {
        uiObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(15);
        Destroy(uiObject);
        Destroy(gameObject);
    }
    
}
