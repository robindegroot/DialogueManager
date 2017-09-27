using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueStart : MonoBehaviour {
    public Animator animator;
	void Start () {
        animator.SetBool("BOpen", false);
        Debug.Log("false");
	}

	void OnTriggerStay(Collider other)
    { 
        if(other.gameObject.tag == "NPC")
        {
            animator.SetBool("BOpen" ,true);
            Debug.Log("true");
        }
        else
        {
            animator.SetBool("BOpen", false);
        }
    }
}
