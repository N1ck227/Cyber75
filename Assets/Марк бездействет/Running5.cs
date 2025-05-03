using UnityEngine;

public class Running5 : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rigidbody2D;
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            rigidbody2D.velocity = new Vector2(speed, rigidbody2D.velocity.y);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody2D.velocity = new Vector2(-speed,  rigidbody2D.velocity.y);
        }
    }
}
