using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    private Action PMove;

    private Rigidbody2D rb;

    [SerializeField] private float Speed;

    private void Awake()
    {
        PMove = new Action();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Start()
    {
        PMove.Enable();
        PMove.Player.Move.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        Vector2 movementInput = PMove.Player.Move.ReadValue<Vector2>();

        float moveX = movementInput.x;

        Vector2 movement = new Vector2(moveX, 0);

        rb.MovePosition(rb.position + movement * Speed * Time.fixedDeltaTime);
    }
}
