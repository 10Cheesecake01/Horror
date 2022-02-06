using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalHealth : MonoBehaviour
{
    // Adding variables.
    public static int currentHealth = 10;
    public int internalHealth;


    // Update is called once per frame
    void Update()
    {
        internalHealth = currentHealth;
        if(currentHealth <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
