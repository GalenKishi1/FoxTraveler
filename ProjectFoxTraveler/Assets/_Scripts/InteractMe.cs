using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractMe : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Veo que es una roca maciza");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Ya no ves la roca");
        }
    }
}
