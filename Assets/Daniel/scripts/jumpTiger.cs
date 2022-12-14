using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpTiger : MonoBehaviour
{
    [SerializeField] private float jumpForce = 4;
    // Start is called before the first frame update
    private Rigidbody2D rb;
   bool isGrounded = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.GetComponent<groundedforever>()){
            isGrounded = true;
        }
    }
  
    void OnCollisionExit(Collision collision){
        if (collision.gameObject.GetComponent<groundedforever>())
        {
            isGrounded = false;
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("perishPit"))
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded == true)
            {
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        }
    }
}
