using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameAnimations : MonoBehaviour
{
    // Adding varabiles.
    public int LightMode;
    public GameObject FlameLight;
    
    void Update()
    {
        if(LightMode == 0){
            StartCoroutine(AnimateLight()); // Playing the animations for the lights.
        }
    }

    IEnumerator AnimateLight() // Randomizing the animations.
    {
        LightMode = Random.Range(1, 4);
        if(LightMode == 1){
            FlameLight.GetComponent<Animation>().Play("TorchAnim1");
        }
        if(LightMode == 2){
            FlameLight.GetComponent<Animation>().Play("TorchAnim2");
        }
        if(LightMode == 3){
            FlameLight.GetComponent<Animation>().Play("TorchAnim3");
        }
        yield return new WaitForSeconds(0.99f);
        LightMode = 0;
    }
}
