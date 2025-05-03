using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunMark : MonoBehaviour
{
    private float speed;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector2 moving = new Vector2(moveHorizontal * speed, rb.linearVelocity.y);

        rb.linearVelocity = moving;

        if (moveHorizontal > 0)
        {
            transform.localScale = new Vector2(1, 1);
        }
        if (moveHorizontal < 0)
        {
            transform.localScale = new Vector2(-1, 1);
        }
    }

}
