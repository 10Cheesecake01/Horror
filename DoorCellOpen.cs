using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorCellOpen : MonoBehaviour
{
    // Declaring the variables and referencing it from PlayerCasting script. 
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject TheDoor;
    public AudioSource CreakSound;
    public GameObject ExtraCross; 

    // Find the distance of the player.
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    // Enabling the pop up message and function to open the door when the mouse is coming near the door. 
    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {
            ExtraCross.SetActive(true);
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action")) // The action key is "E" to open the door.
        {
            if (TheDistance <= 2)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                TheDoor.GetComponent<Animation>().Play("FirstDoorOpenAnim");
                CreakSound.Play();
            }
        }
    }

    // After opening the door.
    void OnMouseExit()
    {
        ExtraCross.SetActive(false); 
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }

}
