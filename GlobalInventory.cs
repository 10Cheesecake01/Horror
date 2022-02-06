using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalInventory : MonoBehaviour
{
    public static bool firstDoorkey = false;
    public bool internalDoorkey;
    public static bool leftEye = false;
    public static bool rightEye = false;

    void Update()
    {
        internalDoorkey = firstDoorkey;
    }
}
