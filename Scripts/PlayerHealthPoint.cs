using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthPoint : MonoBehaviour
{

    [SerializeField] private int maxHp = 100;

    [SerializeField] private int currentHp;

    private Animator animator;
    private PlayerMovement movementScript;
    private bool isDead = false;
    private bool isHurting = false;
    // Start is called before the first frame update
    void Start()
    {
        currentHp = maxHp;

        animator = GetComponent<Animator>();
    }

    public void takeDamage(int dmgAmount)
    {
        if (isDead || isHurting)
        {
            return;
        }

        currentHp -= dmgAmount;

        // if (currentHp <= 0)
        // {
        //     currentHp = 0;
        //     Die();
        // }
        // else
        // {

        //     if (movementScript != null)
        //     {
        //         movementScript.enabled = false;
        //     }
        //     StartCoroutine(HurtRoutine());
        // }
    }

    // private IEnumerator HurtRoutine()
    // {
    //     isHurting = true;
        
    //     Debug.Log("Player is hurt");
    //     animator.SetTrigger("isHurt");

    //     yield return new WaitForSeconds(0.2f);

    //     if (movementScript != null)
    //     {
    //         movementScript.enabled = true;
    //     }

    //     isHurting = false;
    // }

    // private void Die()
    // {
    //     isDead = true;

    //     animator.SetTrigger("isDead");

    //     PlayerMovement movementScript = GetComponent<PlayerMovement>();
    //     if(movementScript != null)
    //     {
    //         movementScript.enabled = false;
    //     }
    // }
}
