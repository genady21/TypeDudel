using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveCamera : MonoBehaviour
{
    [SerializeField]private Transform _player;
    private Vector3 _pos;
    [SerializeField] private float _speedCam = 4;
    [SerializeField] private float _distanceToCamera = -2f;


    private void Awake()
    {
        if (!_player)
        {
            _player = FindObjectOfType<MovePlayer>().transform;
        }
    }
    private void Update()
    {
        if (_player)
        {
            _pos = transform.position;
            _pos.y = _player.position.y-_distanceToCamera;
            _pos.z = -10f;
            transform.position = Vector3.Lerp(transform.position, _pos, _speedCam*Time.deltaTime);
        }
        
    }
}
