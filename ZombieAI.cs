using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAI : MonoBehaviour
{
    // Delcaring the variables.
    public GameObject thePlayer;
    public GameObject theEnemy;
    public float enemySpeed = 0.01f;
    public bool attackTrigger = false;
    public bool isAttacking = false; 
    public AudioSource hurtSound1;
    public AudioSource hurtSound2;
    public AudioSource hurtSound3;
    public int hurtGen;
    public GameObject theFlash;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt (thePlayer.transform); // Enemy looking at the player.

        if(attackTrigger == false) // if the emeny is not attacking, he will come towards the player.
        {
            enemySpeed = 0.01f;
            theEnemy.GetComponent<Animation>().Play("Z_Walk_InPlace 1");
            transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, enemySpeed);
        }

        if(attackTrigger == true && isAttacking == false) // if the enemy is in the attacking range then, he will attack.
        {
            enemySpeed = 0;
            theEnemy.GetComponent<Animation>().Play("Z_Attack 1");
            StartCoroutine(inflictDamage());
        }
    }

    // Zombie attacking.
    void OnTriggerEnter()
    {
        attackTrigger = true;
    }

    void OnTriggerExit()
    {
        attackTrigger = false;
    }
    

    // Sequencing the stage of attacking.
    IEnumerator inflictDamage()
    {
        isAttacking = true;
        hurtGen = Random.Range(1, 4);
        if(hurtGen == 1) // Playing different hurt sound in random order.
        {
            hurtSound1.Play();
        }
        if(hurtGen == 2)
        {
            hurtSound2.Play();
        }
        if(hurtGen == 3)
        {
            hurtSound3.Play();
        }
        theFlash.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        theFlash.SetActive(false);
        yield return new WaitForSeconds(1.1f);
        GlobalHealth.currentHealth -= 5;
        yield return new WaitForSeconds(0.9f);
        isAttacking = false;
    }
}
