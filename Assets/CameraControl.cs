using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    [SerializeField]
    private float damping = 1;
    public GameObject target;
    Vector3 offset;

    void Start()
    {
        offset = target.transform.position - transform.position;

    }


    void Update()
    {
        float currentAngle = transform.eulerAngles.y;
        float desiredAngle = target.transform.eulerAngles.y;
        float angle = Mathf.LerpAngle(currentAngle, desiredAngle, Time.deltaTime * damping);
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
        transform.LookAt(target.transform);
        transform.position = target.transform.position - (rotation * offset);
    }
}
