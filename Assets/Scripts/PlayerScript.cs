using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 1;
    public float jumpForce = 1;

    void Start()
    {

    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        Vector3 vel = new Vector3();

        vel.x = h * speed;
        vel.y = rb.velocity.y;
        vel.z = 0;

        if(Input.GetButtonDown("Jump"))
        {
            vel.y = jumpForce;
        }

        rb.velocity = vel;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"));
        {
            GameManager.instance.score++;
            Destroy(other.gameObject);
        }
    }
}
