using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpTiger : MonoBehaviour
{
    [SerializeField] private float jumpForce = 7;

    float velocity;

    // Start is called before the first frame update
    public Rigidbody2D rb;
    public bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("perishPit"))
        {
            Destroy(gameObject);
            FindObjectOfType<dieScript>().skillissue();
        }
    }

    private float timer;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("floor"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("floor"))
        {
            isGrounded = false;
        }
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}

