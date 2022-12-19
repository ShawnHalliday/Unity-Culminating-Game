using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;
    Vector3 moveDirection;
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation;
    }

    private void Update() 
        {
            MyInput();
        }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

    }

    private void MovePlayer()
    {
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
    }
}