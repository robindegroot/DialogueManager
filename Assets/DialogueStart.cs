using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueStart : MonoBehaviour {
    public Animator animator;

    private void FixedUpdate()
    {
        animator.SetBool("BOpen", false);
    }
    void OnTriggerStay(Collider other)
    { 
        if(other.gameObject.tag == "NPC")
        {
            animator.SetBool("BOpen" ,true); 
        }
        
    }
}
