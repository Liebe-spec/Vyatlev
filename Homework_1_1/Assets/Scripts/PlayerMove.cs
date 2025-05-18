using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float _speedMove = 8f;
    public float SpeedMove => _speedMove;
    private CharacterController controller;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        
        float x = Input.GetAxis("Vertical") * SpeedMove;
        float z = Input.GetAxis("Horizontal") * SpeedMove;

        

        x *= Time.deltaTime;
        z *= Time.deltaTime;

        
        Vector3 movement = new Vector3(z, 0, x);
        movement = Vector3.ClampMagnitude(movement, _speedMove);
        movement = transform.TransformDirection(movement);

        transform.Translate(z, 0, x);
        controller?.Move(movement);
    }
}
