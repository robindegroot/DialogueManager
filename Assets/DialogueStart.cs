using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueStart : MonoBehaviour {
    public GameObject rob;
	void Start () {
        rob.SetActive(false);
        Debug.Log("false");
	}

	void OnTriggerEnter (Collider other)
    { 
            rob.SetActive(true);
        Debug.Log("true");
    }
}
