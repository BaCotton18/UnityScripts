using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class textChange : MonoBehaviour
{
    public TextMeshProUGUI txt;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Figurine"))
        {
            if(other.gameObject.name == "Sora")
            {
                txt.text = "This is Sora from Kingdom Hearts! " +
					"He wields the keyblade. It probably opens " +
					"doors or something. I don't know, I've never " +
					"played Kingdom Hearts.";
            }
            else if(other.gameObject.name == "Model 2")
            {
                txt.text = "This is the Master Sword! It can only be " +
                    "used by Link, the legendary Hero of Time. It is also " +
                    "the only thing that can defeat Ganon, the holder of the " +
                    "triforce of power.";
            }
            else if(other.gameObject.name == "Blue Chaos Emerald")
            {
                txt.text = "This is a Chaos Emerald! These things are " +
                    "incredibly powerful. Even if you have only one you " +
                    "can still do things like stop time and teleport. Anyone " +
                    "who gets all seven of them will have unimaginable power.";
            }
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Figurine"))
        { 
            txt.text = "Hey there! Hand me one of those figurines and " +
            "I'll tell you about it!";
        }
        
    }
}
