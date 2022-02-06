using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public GameObject theAmmo;
    public GameObject ammoDisplayBox;

    // Making the Ammo box disapper while giving us the ammo required.
    void OnTriggerEnter() 
    {
        theAmmo.SetActive(false);
        GlobalAmmo.ammoCount += 7;
        ammoDisplayBox.SetActive(true);
    }
}
