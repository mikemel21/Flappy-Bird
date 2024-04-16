using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour {
    public float speed = 3.4f;
    public float gravityScale = 2f;
    public float jumpHeight = 4f;
    private bool alive = true;
    public Camera mainCamera;
    private Rigidbody2D rb;
    private CapsuleCollider2D playerCollider;

    private float tiltAngle = 0;

    // Start is called before the first frame update
    void Start()
    {
        alive = true;
        tiltAngle = 0;
        rb = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<CapsuleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && alive) {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
        }

        if (rb.velocity.y > 0 && alive) {
            tiltAngle = Mathf.Clamp(rb.velocity.y * 45 / 10f, -45, 45);
        } else if (rb.velocity.y < 0 && alive) {
            tiltAngle = -45f;
        }   
        transform.rotation = Quaternion.Euler(0f, 0f, tiltAngle);  
    }

    void OnTriggerEnter2D (Collider2D collision) {
        if (collision.gameObject.CompareTag("Pipe")) {
            Debug.Log("Player hit pipe.");
            // stop player movement
            rb.velocity = new Vector2(0, 0);
            alive = false;
        }
    }
}
