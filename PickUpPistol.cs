using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpPistol : MonoBehaviour
{
    // Declaring the variables and referencing it from PlayerCasting script. 
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject FakePistol;
    public GameObject RealPistol;
    public GameObject GuideArrow; 
    public GameObject ExtraCross;
    public GameObject TheJumpTrigger;

    // Find the distance of the player.
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    // Enabling the pop up message and function to pick up the gun, when the mouse is coming near the gun. 
    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {
            ExtraCross.SetActive(true);
            ActionText.GetComponent<Text>().text = " Pick up the gun. ";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action")) // The action key is "E" to pick up the gun.
        {
            if (TheDistance <= 2)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                FakePistol.SetActive(false);
                RealPistol.SetActive(true);
                ExtraCross.SetActive(false);
                GuideArrow.SetActive(false);
                TheJumpTrigger.SetActive(true); // Active the Jump Scare.
            }
        }
    }

    // After picking up the gun.
    void OnMouseExit()
    {
        ExtraCross.SetActive(false); 
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }

}
