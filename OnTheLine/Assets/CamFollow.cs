using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public GameObject target;
    public float interpVelocity;
    Vector3 targetPos;
    public Vector3 offset;
    void Start()
    {
        targetPos = transform.position;
    }

    public void setTarget(GameObject g)
    {
        target = g;
    }
    
    void LateUpdate()
    {

        if (target)
        {
            Vector3 posNoZ = transform.position;
            posNoZ.z = target.transform.position.z;

            Vector3 targetDirection = (target.transform.position - posNoZ);

            interpVelocity = targetDirection.magnitude * 5f;

            Vector3 factorTowardsTarget = (targetDirection.normalized * interpVelocity * Time.deltaTime);

            targetPos = new Vector3(transform.position.x, transform.position.y + factorTowardsTarget.y, transform.position.z);

            transform.position = Vector3.Lerp(transform.position, targetPos + offset, 0.25f);
        }
    }
}
