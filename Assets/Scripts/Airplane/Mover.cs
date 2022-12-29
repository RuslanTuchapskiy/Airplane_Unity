using UnityEngine;

public class Mover : MonoBehaviour
{
      [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speed;
    [SerializeField] private float _torqueForce;


    private float _horizontalInput;
    private float _verticalInput;


    private void Update(){

        _rigidbody.velocity =transform.forward * _speed * Time.deltaTime;
        _horizontalInput = Input.GetAxis("Horizontal");
         _verticalInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate(){
        _rigidbody.AddTorque(-_verticalInput * _torqueForce,_horizontalInput*_torqueForce,-_horizontalInput*_torqueForce);
         
    }
}
