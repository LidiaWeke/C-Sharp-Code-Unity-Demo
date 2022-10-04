using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionObjetos : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag.Equals("Player")) ;
        {
            Destroy(this.gameObject);
        }

    }
}
