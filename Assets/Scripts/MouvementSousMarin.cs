using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlePoissonDash : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private float _vitessePromenade;
    private Vector3 directionInput;
   
    void Start()
    {
        _rb = GetComponent<Rigidbody>();        
     /*   _animator = GetComponent<Animator>();   */

    }

    void OnPromener(InputValue Bouton)
    {        Vector3 mouvement = directionInput;

        
        if(Bouton.isPressed ){
                    Debug.Log("oui");
                    Vector2 directionAvecVitesse = Bouton.Get<Vector2>() * _vitessePromenade;
                    directionInput = new Vector3(directionAvecVitesse.x, 0f, directionAvecVitesse.y);
                    _rb.AddRelativeForce(directionAvecVitesse.x, 0f, directionAvecVitesse.y);        
                 /*   _rb.AddForce(mouvement, ForceMode.VelocityChange);*/

                }
                
                else{
                    Debug.Log("non");

                } 
            /*
            _rb.AddRelativeForce(Vector3.forward * 1f, ForceMode.VelocityChange);

            

            */        
       
    }

    void FixedUpdate() {

    }
 
   
/*
    // variables de contr�le d'animation
    [SerializeField] private float _modifierAnimTranslation;
    private Animator _animator;
    private float _rotationVelocity;


    void OnPromener(InputValue directionBase)
    {
      
    }

    void FixedUpdate()
    {
        // calculer et appliquer la translation
        float rotation = 0f;
        // si on a une direction d'input

        // appliquer la vitesse de translation
        

        // calculer un modifiant pour la vitesse d'animation
        Vector3 vitesseSurPlane = new Vector3(_rb.velocity.x, 0f, _rb.velocity.z);
        _animator.SetFloat("Vitesse", vitesseSurPlane.magnitude * _modifierAnimTranslation);
        _animator.SetFloat("Deplacement", vitesseSurPlane.magnitude);
    }   */
}
