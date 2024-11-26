using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController characterController;
    private Vector3 playerMovement;
    private float speed = 5f;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    public void moveToDirection(Vector2 input) {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        characterController.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
    }
}
