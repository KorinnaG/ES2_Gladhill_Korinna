using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlePoissonDash : MonoBehaviour
{
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void OnAvancer()
    {
        
        _rb.AddRelativeForce(Vector3.forward * 1f, ForceMode.VelocityChange);
    }
}
