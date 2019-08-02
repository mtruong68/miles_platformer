using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool lmoving = false;
    private bool rmoving = false;
    private bool jumping = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && !jumping)
        {
            jumping = true;
            rb.AddForce(new Vector2(0, 400));
            StartCoroutine("NoDoubleJumpsAllowed");
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && !lmoving)
        {
            rb.velocity = new Vector2(-4, 0);
            lmoving = true;
            rmoving = false;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && !rmoving)
        {
            rb.velocity = new Vector2(4, 0);
            rmoving = true;
            lmoving = false;
        }

        if ((Input.GetKeyUp(KeyCode.RightArrow) && rmoving) ||
            (Input.GetKeyUp(KeyCode.LeftArrow) && lmoving))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            rb.angularVelocity = 0;
            lmoving = false;
            rmoving = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("First", LoadSceneMode.Single);
        }
  
    }

    IEnumerator NoDoubleJumpsAllowed()
    {
        yield return new WaitForSeconds(1.2f);
        jumping = false;
    }
}
