using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    Rigidbody2D rb;
    public int speed = 10;

    IEnumerator Start()
    {
        rb = GetComponent<Rigidbody2D>();
        yield return null;
        rb.velocity = new Vector2(speed, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "side")
        {
            speed = -1 * speed;
            rb.velocity = new Vector2(speed, 0);
        }
    }
}
