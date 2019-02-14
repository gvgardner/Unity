using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

public class PlayerControllerFPS : MonoBehaviour
{
    [SerializeField] private Controls _controls;
    [SerializeField] private float _speed = 5f;

    private Vector2 _moveAxis;

    private void OnEnable()
    {
        _controls.Player.Move.performed += HandleMove;
        _controls.Player.Move.Enable();
    }

    private void OnDisable()
    { 
        _controls.Player.Move.performed -= HandleMove;
        _controls.Player.Move.Disable();
    }

    private void HandleMove(InputAction.CallbackContext context)
    {
        _moveAxis = context.ReadValue<Vector2>();
        Debug.Log($"MoveAxis (_moveAxis)");
    }

    private void Update()
    {
        transform.position += new Vector3(
            _moveAxis.x * Time.deltaTime * _speed,
            0,
            _moveAxis.y * Time.deltaTime * _speed);
    }
}