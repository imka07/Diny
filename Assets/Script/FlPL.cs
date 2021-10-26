using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlPL : MonoBehaviour
{
    private Vector3 startPos;
    Rigidbody2D rb;
    public float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.localPosition;
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Invoke("Fall", 0.01f);
        Invoke(nameof(Respawn), 2);
    }
    void Fall()
    {
        rb.isKinematic = false;
    }

    void Respawn()
    {
        transform.localPosition = startPos;
        rb.isKinematic = true;
        rb.velocity = Vector2.zero;
    }
}
