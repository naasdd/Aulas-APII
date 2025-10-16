using System;
using UnityEngine;

public class PlayerITJ : MonoBehaviour
{
    private float speed = 5f;

    private Rigidbody2D _rb2D;

    private void Start()
    {
        _rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MoverLinear();
    }

    private void MoverLinear()
    {
        var mov = 0f;

        if (Input.GetKey(KeyCode.W)) mov += 1f;
        if (Input.GetKey(KeyCode.S)) mov -= 1f;

        if (mov == 0f) return;
        
        _rb2D.velocity = mov * speed * transform.up;
    }
}
