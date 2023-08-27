using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad de movimiento del personaje

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float moveInputX = Input.GetAxis("Horizontal"); // -1 para izquierda, 1 para derecha
        float moveInputY = Input.GetAxis("Vertical");   // -1 para abajo, 1 para arriba

        // Calcula la velocidad del movimiento
        Vector2 moveVelocity = new Vector2(moveInputX * moveSpeed, moveInputY * moveSpeed);
        rb.velocity = moveVelocity;

        // Voltear el sprite del personaje en la dirección horizontal
        if (moveInputX < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (moveInputX > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}