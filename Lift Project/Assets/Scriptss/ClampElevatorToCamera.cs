using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampElevatorToCamera : MonoBehaviour
{
    public Transform target;

    private void FixedUpdate()
    {
        Vector3 targetPos = target.position;

        targetPos.x = transform.position.x;
    }
}
