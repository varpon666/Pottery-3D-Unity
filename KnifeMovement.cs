using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class KnifeMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody _knife;
    private Vector3 _direction;

    private bool _isMoving = false;

    private void Start()
    {
        _knife = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _isMoving = Input.GetMouseButton(0);

        if (_isMoving)
            _direction = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0f) * _speed * Time.deltaTime;
    }

    private void FixedUpdate()
    {
        if (_isMoving)
            _knife.position += _direction;
    }
}
