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

    void OnPromener(InputValue Bouton)
    {
        if(Bouton.isPressed ){
            Debug.Log("oui");
        }
        else{
            Debug.Log("non");

        }
        
        _rb.AddRelativeForce(Vector3.forward * 1f, ForceMode.VelocityChange);
    }

    
}