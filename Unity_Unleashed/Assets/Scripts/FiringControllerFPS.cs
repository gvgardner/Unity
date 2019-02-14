using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

public class FiringControllerFPS : MonoBehaviour
{
    [SerializeField] private Controls _fireControls;
    [SerializeField] private GameObject _bulletPrefab;


    private void OnEnable()
    {
        _fireControls.Player.Fire.performed += HandleFire;
        _fireControls.Player.Fire.Enable();
    }

    private void OnDisable()
    {
        _fireControls.Player.Fire.performed -= HandleFire;
        _fireControls.Player.Fire.Disable();
    }

    private void HandleFire(InputAction.CallbackContext context)
    {
        Instantiate(_bulletPrefab, transform.position, transform.rotation);
        Debug.Log("Fire");
    }
}
