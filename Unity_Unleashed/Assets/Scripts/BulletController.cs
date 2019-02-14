using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private float _bulletSpeed = 5f;

    
    // Update is called once per frame
    void Update()
    {
        //Vector3 shoot = (transform.position * Time.deltaTime * _bulletSpeed);
        //Vector3.Angle(transform.forward, shoot);

        transform.position = transform.forward * Time.deltaTime * _bulletSpeed;
    }
}
