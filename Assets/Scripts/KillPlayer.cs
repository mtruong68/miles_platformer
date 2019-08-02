using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.name == "Player")
        {
            Destroy(c.gameObject);
            SceneManager.LoadScene("First", LoadSceneMode.Single);
        } 
    }
}
