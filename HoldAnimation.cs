using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldAnimation : MonoBehaviour
{
    [SerializeField] private Animator AnimationController;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Figurine"))
        {
            AnimationController.SetBool("Holding", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Figurine"))
        {
            AnimationController.SetBool("Holding", false);
        }
    }
}
