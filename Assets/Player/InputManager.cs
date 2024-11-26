using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private Input playerInput;
    private Input.MovementActions movement;

    private PlayerMovement playerMovement;
    void Awake()
    {
       playerInput = new Input();
       movement = playerInput.Movement; 
       playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update() {
        playerMovement.moveToDirection(movement.Movement.ReadValue<Vector2>());
    }

    private void OnEnable() {
        movement.Enable();
    }

    private void onDisable() {
        movement.Disable();
    }
}
