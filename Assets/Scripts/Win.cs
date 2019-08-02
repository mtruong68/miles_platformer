using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == "Player")
        {
            Transform child = transform.Find("win");
            child.gameObject.SetActive(true);
        }
    }
}
