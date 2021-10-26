using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVePL : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        dir = transform.right;
    }

    // Update is called once per frame
    private void Update()
    {

        Move();
   
    }
    private void Move()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position + transform.up * 0.1f + transform.right * dir.x * 0.7f, 0.1f);

        if (colliders.Length > 1) dir *= -1f;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, Time.deltaTime);
    }
}
