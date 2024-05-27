using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GroundColl : MonoBehaviour
{
    [SerializeField] private float _jumpForce;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0)
            MovePlayer.instance._rb.velocity = Vector2.up * _jumpForce;
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.name == "DeadZone")
        {
              float RandX = Random.Range(-1.2f, 2.6f);
              float RandY = Random.Range(transform.position.y+22f,transform.position.y+22f);
              transform.position = new Vector3(RandX, RandY, 0);
        }
    }
}
