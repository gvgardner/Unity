using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private float _speed = 4.5f;

    private void Update()
    {
        Vector3 run = (transform.position - _player.transform.position);
        transform.Translate(run.normalized * Time.deltaTime * _speed);
    }
}
