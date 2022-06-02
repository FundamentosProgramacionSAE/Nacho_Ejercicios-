using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPrueba : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            Debug.Log("Dentro");
            Destroy(this.gameObject);
        }
    }
}
