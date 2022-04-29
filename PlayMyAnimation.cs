using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMyAnimation : MonoBehaviour
{
    [SerializeField] private Animator MyAnimationController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MyAnimationController.SetBool("PlayAnim", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MyAnimationController.SetBool("PlayAnim", false);
        }
    }
}
