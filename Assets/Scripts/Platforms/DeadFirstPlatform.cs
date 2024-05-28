using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadFirstPlatform : MonoBehaviour
{
    [SerializeField] private GameObject _fisrtPlatform;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.name == "Player")
        {
            Destroy(_fisrtPlatform);
        }
    }
}
