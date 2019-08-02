using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.name == "Player")
        {
            c.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 500));
            Destroy(this.transform.parent.gameObject);
        }
    }
}
