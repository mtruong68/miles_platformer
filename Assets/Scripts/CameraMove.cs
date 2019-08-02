using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(player.position.x, 0, -10);
    }

    // Update is called once per frame
    void Update()
    {
        if (player && player.position.x > -3.23 && player.position.x < 23)
        {
            transform.position = new Vector3(player.position.x, 0, -10);
        }
    }
}
