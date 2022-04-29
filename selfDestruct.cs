using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfDestruct : MonoBehaviour
{
    [SerializeField] private GameObject self;
    private bool entered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            entered = true;
            //Goodbye cruel world :(
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (entered = true)
        {
            Destroy(self);
        }
    }
}
