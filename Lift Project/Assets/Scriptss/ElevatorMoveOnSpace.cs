using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ElevatorMoveOnSpace : MonoBehaviour
{
    public InputActionMap controls;

    public float elavatorRaiseAmount = 3;

    void Awake()
    {
        controls["Floor Up"].performed += _ => FloorUp();
        controls["Floor Down"].performed += _ => FloorDown();
    }

    void FloorUp()
    {
        transform.Translate(new Vector3(0, elavatorRaiseAmount, 0), Space.World);
    }

    void FloorDown()
    {
        transform.Translate(new Vector3(0, -elavatorRaiseAmount, 0), Space.World);
    }

    void OnEnable()
    {
        controls.Enable();
    }

    void OnDisable()
    {
        controls.Disable();
    }
}
