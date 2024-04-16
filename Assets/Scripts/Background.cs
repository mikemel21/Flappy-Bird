using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float speed = -3f;

    void FixedUpdate()
    {
        transform.position = transform.position + Vector3.right * speed * Time.deltaTime;
    }
}
