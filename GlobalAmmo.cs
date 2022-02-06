using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalAmmo : MonoBehaviour
{
    // Declaring the variables.
    public static int ammoCount;
    public GameObject ammoDisplay;
    public int internalAmmo;

    // counting and dipslay the ammo.
    void Update()
    {
        internalAmmo = ammoCount;
        ammoDisplay.GetComponent<Text>().text = "" + ammoCount;
    }
}
