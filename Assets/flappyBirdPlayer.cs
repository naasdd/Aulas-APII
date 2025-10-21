using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flappyBirdPlayer : MonoBehaviour
{

    [SerializeField] private float jumpSpeed = 5f;
    [SerializeField] private Transform teto;

    private Rigidbody2D _rb2D;

    private void Awake()
    {
        _rb2D = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        Pular();
    }

    private void SubiuDemais()
    {
        if (transform.position.y > teto.position.y);
    }

    private void Pular()
    {
        if (!Input.GetKeyDown(KeyCode.Space)) return;

        _rb2D.velocity = Vector2.up * jumpSpeed;
    }
}
