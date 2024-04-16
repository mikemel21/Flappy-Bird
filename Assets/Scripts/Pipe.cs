using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed = 3.5f;
    public bool canMove = true;

    private BoxCollider2D pipeCollider;

    // Start is called before the first frame update
    void Start()
    {
        pipeCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {  
        if (canMove) {
            // rb.velocity = new Vector2(speed, 0);
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }

    void OnCollisionEnter2D (Collision2D collision) {
        if (collision.gameObject.CompareTag("Player")) {
            transform.position = Vector3.zero;
            Debug.Log("hit");
        }
    }
}
