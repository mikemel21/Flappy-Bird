using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public float speed = -3.4f;
    private BoxCollider2D groundCollider;

    // Start is called before the first frame update
    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = transform.position + Vector3.right * speed * Time.deltaTime;
    }
}
