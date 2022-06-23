using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private Transform _target;

    private float _yOffset;
    private float _xOffset;
    private float _zOffset;
    private float _speed;

    private void Awake()
    {
        _yOffset = 4;
        _speed = 2;
        _zOffset = -5f;
    }

    private void LateUpdate()
    {
        Vector3 targetPosition = _player.position + _player.transform.TransformDirection(new Vector3(_xOffset, _yOffset, _zOffset));
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * _speed);

        transform.LookAt(_target);
    }
}
